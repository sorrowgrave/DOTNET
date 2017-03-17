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
    public partial class EncryptFile : Form
    {
        User user;

        byte[] signedHash;

        string fileName;
        string outputFolderName;

        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
        FileIO fileIO = new FileIO();
        public EncryptFile()
        {
            InitializeComponent();
        }

        public EncryptFile(User user)
        {
            InitializeComponent();
            this.user = user;

            
        }

        private void Encrypt_Load(object sender, EventArgs e)
        {
            backgroundWorker.WorkerReportsProgress = true;

            encryptFileTooltip = new ToolTip();
            encryptFileTooltip.ToolTipIcon = ToolTipIcon.Info;
            encryptFileTooltip.IsBalloon = true;

            encryptFileTooltip.SetToolTip(browseOutputButton, "Choose the folder to which you want to save the AES key and MD5 checksum.");
            encryptFileTooltip.SetToolTip(browseInputButton, "Browse for the file you wish to encrypt.");
            encryptFileTooltip.SetToolTip(usersComboBox, "Choose the public key of the person you would like to send the encrypted file to.");
            encryptFileTooltip.SetToolTip(filePathTextBox, "Select the file you wish to encrypt.");
            encryptFileTooltip.SetToolTip(infoLabel, "Set a random chosen password or string for enhanced encryption. " + Environment.NewLine +
                                                                 "You do not have to remember this, nor does the receiver need to know this password. ");


            usersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            usersComboBox.DataSource = UserDB.getUserNames();
            usersComboBox.DisplayMember = "Name";
            usersComboBox.ValueMember = "Id";
        }


        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;
            byte[] passwordBytes = (byte[]) e.Argument;

            AESEncryption.AES_Encrypt(fileName, outputFolderName + "\\" + Path.GetFileName(fileName), passwordBytes,  backgroundWorker);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar.Value = e.ProgressPercentage;
            this.percentLabel.Text = e.ProgressPercentage + "%";


        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Application.UseWaitCursor = false;
            waitLabel.Text = "Encryption Completed Successfully!";
            MessageBox.Show("File has successfully been encrypted!", "File encrypted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void encryptFileButton_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            waitLabel.Text = "Please, wait while we are encrypting your file, this could take some time ";
            percentLabel.Text = "0 %";

            Application.UseWaitCursor = true;
            waitLabel.Visible = true;
            percentLabel.Visible = true;
            progressBar.Visible = true;

                try
                {
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(passwordTextBox.Text);

                    string publicKey = System.Text.Encoding.Default.GetString(UserDB.GetPublicKey(Convert.ToInt32(usersComboBox.SelectedValue.ToString())));

                    rsa.FromXmlString(publicKey);

                    fileIO.WriteBytes(outputFolderName + "\\AESPassword.txt", rsa.Encrypt(passwordBytes, true));

                    //Hash passwoord met SHA256

                    passwordBytes = SHA256.Create().ComputeHash(passwordBytes);               

                    backgroundWorker.RunWorkerAsync(passwordBytes);

                    string hash = HashFile(fileName);

                    fileIO.Write(outputFolderName + "\\OriginalMD5.txt", hash);

                    File.WriteAllBytes(outputFolderName + "\\SignedHashChecksum.txt", signedHash);

                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("File does not exist.");
                    return;
                }
                catch(CryptographicException)
                {
                    MessageBox.Show("Something went wrong at the attempt of encrypting the file ;( Are you using the right keys?");
                    return;
                }
 
        }

        private void browseInputButton_Click(object sender, EventArgs e)
        {
            string startdir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.InitialDirectory = startdir;
            openFileDialog.Filter = "All|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                folderpathTextBox.Visible = true;
                browseOutputButton.Visible = true;
                outputLabel.Visible = true;

                try
                {
                    fileName = openFileDialog.FileName;
                    filePathTextBox.Text = fileName;

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
                if (Path.GetDirectoryName(fileName) == folderBrowserDialog.SelectedPath)
                {
                    MessageBox.Show("Please select a different folder from the input file.");
                    return;
                }

                enterPassLabel.Visible = true;
                passwordTextBox.Visible = true;
                infoLabel.Visible = true;

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
                byte[] hash = md5.ComputeHash(stream);

                rsa.FromXmlString(user.PrivateKey);
                signedHash = rsa.PrivateEncryption(hash);

                foreach (byte b in hash)
                    sb.Append(b.ToString("x2"));

                stream.Seek(0, SeekOrigin.Begin);
            }

            return sb.ToString();
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            passwordTextBox.Text = passwordTextBox.Text.Trim(' ');

            if (!(passwordTextBox.Text == string.Empty))
            {
                selectKeyLabel.Visible = true;
                usersComboBox.Visible = true;
                encryptButton.Visible = true;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(passwordTextBox.Text == string.Empty))
            {
                selectKeyLabel.Visible = true;
                usersComboBox.Visible = true;
                encryptButton.Visible = true;
            }
            else
            {
                selectKeyLabel.Visible = false;
                usersComboBox.Visible = false;
                encryptButton.Visible = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
