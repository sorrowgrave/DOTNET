using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using RSAExtensions;
using AESExtensions;
using System.Numerics;


namespace BasicSec04
{
    public partial class DecryptFile : Form
    {
        User user;
        AutoResetEvent _resetEvent = new AutoResetEvent(false);

        byte[] aesKeyBytes;
        byte[] hashBytes;
        byte[] decryptedFileHash;

        string inputFileName;
        string outputFileName;
        string outputFolderName;
        string aesKeyFileName;
        string hashFileName;

        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);

        FileIO fileIO = new FileIO();
        public DecryptFile()
        {
            InitializeComponent();
        }

        public DecryptFile(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void DecryptFile_Load(object sender, EventArgs e)
        {

            backgroundWorker.WorkerReportsProgress = true;

            decryptTooltip = new ToolTip();
            decryptTooltip.ToolTipIcon = ToolTipIcon.Info;
            decryptTooltip.IsBalloon = true;

            decryptTooltip.SetToolTip(browseInputButton, "Browse for the file you wish to decrypt.");
            decryptTooltip.SetToolTip(browseAESKeyButton, "Select the AES key needed for decrypting the file.");
            decryptTooltip.SetToolTip(browseHashButton, "Browse for the hash file to verify nothing has changed to the original file. ");
            decryptTooltip.SetToolTip(usersComboBox, "Select the user who encrypted the hash file");
            decryptTooltip.SetToolTip(selectPubKeyLabel, "Select the Public key needed for decrypting the hash file."
                + Environment.NewLine + "This has to be the public key of the sender");

            usersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            usersComboBox.DataSource = UserDB.getUserNames();
            usersComboBox.DisplayMember = "Name";
            usersComboBox.ValueMember = "Id";
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;
            byte[] passwordBytes = (byte[])e.Argument;

            AESEncryption.AES_Decrypt(inputFileName, outputFileName, passwordBytes, backgroundWorker);

            _resetEvent.Set();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar.Value = e.ProgressPercentage;
            this.percentLabel.Text = e.ProgressPercentage + "%";
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Application.UseWaitCursor = false;
            progressBar.Visible = false;
            waitLabel.Visible = false;

            percentLabel.Visible = false;
            hashCheckLabel.Visible = true;
            hashStatusLabel.Visible = true;

            string MD5Hash = HashFile(outputFileName);

            fileIO.Write(outputFolderName + "\\CurrentMD5.txt", MD5Hash);

            byte[] unsignedHash = rsa.PublicDecryption(hashBytes);

            if (unsignedHash.SequenceEqual(decryptedFileHash))
            {
                hashCheckLabel.ForeColor = Color.Green;
                hashCheckLabel.Text = "File has not been altered during encryption and thus resides in original state.";
            }
            else
            {
                hashCheckLabel.ForeColor = Color.Red;
                hashCheckLabel.Text = "Warning! This file has either been altered or sent by a different user then selected!";
            }

            MessageBox.Show("File has successfully been decrypted!", "File decrypted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Cancel()
        {
            backgroundWorker.CancelAsync();
            _resetEvent.WaitOne(); // will block until _resetEvent.Set() call made
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void decryptFileButton_Click(object sender, EventArgs e)
        {

            progressBar.Value = 0;
            waitLabel.Text = "Please, wait while we are decrypting your file, this could take some time  ";
            percentLabel.Text = "0 %";

            hashCheckLabel.Visible = false;
            hashStatusLabel.Visible = false;

            Application.UseWaitCursor = true;
            waitLabel.Visible = true;
            progressBar.Visible = true;
            percentLabel.Visible = true;

            try
            {
                rsa.FromXmlString(user.PrivateKey);

                byte[] unsignedAESKey = rsa.Decrypt(aesKeyBytes, true);

                if (unsignedAESKey == null)
                {
                    MessageBox.Show("The AES key is invalid or signed by another user, file cannot be decrypted.", "Invalid Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
                byte[] passwordBytes = SHA256.Create().ComputeHash(unsignedAESKey);

                string publicKey = System.Text.Encoding.Default.GetString(UserDB.GetPublicKey(Convert.ToInt32(usersComboBox.SelectedValue.ToString())));

                rsa.FromXmlString(publicKey);

                outputFileName = outputFolderName + "\\" + Path.GetFileName(inputFileName);

                backgroundWorker.RunWorkerAsync(passwordBytes);
                    
            }
            catch(CryptographicException)
            {
                Application.UseWaitCursor = false;
                MessageBox.Show("Busted! You either selected wrong input files, or this file was just not meant to be decrypted by you ;)");
                return;
            }
            catch (FileNotFoundException)
            {
                Application.UseWaitCursor = false;
                MessageBox.Show("File does not exist.");
                return;
            }

        }

        private void browseInputButton_Click(object sender, EventArgs e)
        {
            string startdir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openInputFileDialog.InitialDirectory = startdir;
            openInputFileDialog.Filter = "All|*.*";

            if (openInputFileDialog.ShowDialog() == DialogResult.OK)
            {
                folderpathTextBox.Visible = true;
                browseOutputButton.Visible = true;
                outputLabel.Visible = true;


                try
                {
                    inputFileName = openInputFileDialog.FileName;
                    filePathTextBox.Text = inputFileName;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex + "");
                }
            }

        }

        private void browseOutputButton_Click(object sender, EventArgs e)
        {
            string startdir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            folderBrowserDialog.SelectedPath = startdir;

            DialogResult folderBrowser = folderBrowserDialog.ShowDialog();

            if (folderBrowser == DialogResult.OK)
            {
                if (Path.GetDirectoryName(inputFileName) == folderBrowserDialog.SelectedPath)
                {
                    MessageBox.Show("Please select a different folder from the input file.");
                    return;
                }

                browseAESKeyButton.Visible = true;
                aesPathTextBox.Visible = true;
                selectKeyLabel.Visible = true;

                try
                {
                    outputFolderName = folderBrowserDialog.SelectedPath;
                    folderpathTextBox.Text = outputFolderName;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                }
            }
        }

        private void browseAESKeyButton_Click(object sender, EventArgs e)
        {
            string startdir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openAESFileDialog.InitialDirectory = startdir;
            openAESFileDialog.Filter = "txt|*.txt";

            if (openAESFileDialog.ShowDialog() == DialogResult.OK)
            {
                hashGroupBox.Visible = true;
                selectHashLabel.Visible = true;
                hashPathTextBox.Visible = true;
                browseHashButton.Visible = true;

                try
                {
                    aesKeyFileName = openAESFileDialog.FileName;
                    aesPathTextBox.Text = aesKeyFileName;
                    aesKeyBytes = File.ReadAllBytes(aesKeyFileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                }
            }
        }

        private void browseHashButton_Click(object sender, EventArgs e)
        {
            string startdir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openHashFileDialog.InitialDirectory = startdir;
            openHashFileDialog.Filter = "Text|*.txt";

            if (openHashFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectPubKeyLabel.Visible = true;
                usersComboBox.Visible = true;
                decryptButton.Visible = true;

                try
                {
                    hashFileName = openHashFileDialog.FileName;
                    hashPathTextBox.Text = hashFileName;
                    hashBytes = File.ReadAllBytes(openHashFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                }
            }
        }
        public string hashToString(byte[] unsigned)
        {
            StringBuilder sb = new StringBuilder();

            foreach (byte b in unsigned)
                sb.Append(b.ToString("x2"));

            return sb.ToString();
        }

        public string HashFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                return HashFile(fs);
            }
        }
        public string HashFile(FileStream stream)
        {
            StringBuilder sb = new StringBuilder();

            if (stream != null)
            {
                stream.Seek(0, SeekOrigin.Begin);

                MD5 md5 = MD5CryptoServiceProvider.Create();
                decryptedFileHash = md5.ComputeHash(stream);

                foreach (byte b in decryptedFileHash)
                    sb.Append(b.ToString("x2"));

                stream.Seek(0, SeekOrigin.Begin);
            }

            return sb.ToString();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }


    }
}
