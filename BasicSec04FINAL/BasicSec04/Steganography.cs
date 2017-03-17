using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteganographyExtensions;
using System.Drawing.Imaging;

namespace BasicSec04
{
    public partial class Steganography : Form
    {
        protected bool validData;
        string path;
        protected Image image;
        protected Thread getImageThread;

        //[STAThread]
        //static void Main()
        //{
        //    Application.Run(new Steganography());
        //}

        public Steganography()
        {
            InitializeComponent();
        }
        
        protected void LoadImage()
        {
            //image = new Bitmap(@"C:\Users\11301497\SkyDrive\Afbeeldingen\DragonFire.png");
            image = (Bitmap)Image.FromFile(path);
        }

        private void Steganography_DragEnter(object sender, DragEventArgs e)
        {
            string filename;
            validData = GetFilename(out filename, e);
            if (validData)
            {
                path = filename;
                getImageThread = new Thread(new ThreadStart(LoadImage));
                getImageThread.Start();
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private bool GetFilename(out string filename, DragEventArgs e)
        {
            bool ret = false;
            filename = String.Empty;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                Array data = ((IDataObject)e.Data).GetData("FileDrop") as Array;
                if (data != null)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is String))
                    {
                        filename = ((string[])data)[0];
                        string ext = Path.GetExtension(filename).ToLower();
                        if ((ext == ".gif") || (ext == ".png") || (ext == ".bmp") || (ext == ".jpg"))
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }

        private void getPictureButton_Click(object sender, EventArgs e)
        {
            string startdir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.InitialDirectory = startdir;
            openFileDialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path = openFileDialog.FileName;
                    LoadImage();
                    fotoPicturebox.Image = image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                }
            }
        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveTextButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)fotoPicturebox.Image;

            string text = messageTextBox.Text;

            if (text.Equals(""))
            {
                MessageBox.Show("De tekst die je wil verbergen kan niet leeg zijn.", "Waarschuwing");
                return;
            }

            //if (encryptCheckBox.Checked)
            //{
            //    if (passwordTextBox.Text.Length < 6)
            //    {
            //        MessageBox.Show("Please enter a password with at least 6 characters", "Warning");

            //        return;
            //    }
            //    else
            //    {
            //        text = Crypto.EncryptStringAES(text, passwordTextBox.Text);
            //    }
            //}

            bmp = SteganographyHelper.embedText(text, bmp);

            MessageBox.Show("De tekst is succesvol in de foto verborgen,"+Environment.NewLine+
                "Kies een locatie om de foto met verborgen tekst op te slaan.", "Verborgen tekst opgeslagen");

            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp|Jpeg Image|*.jpg";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                switch (save_dialog.FilterIndex)
                {
                    case 1:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Png);
                        } break;
                    case 2:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Bmp);
                        } break;
                    case 3:
                        {
                            //ImageCodecInfo ici = null;

                            //ImageFormat format = ImageFormat.Jpeg;
                            //ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

                            //foreach (ImageCodecInfo codec in codecs)
                            //{
                            //    if (codec.FormatID == format.Guid)
                            //    {
                            //        ici = codec;
                            //    }
                            //}

                            //EncoderParameters ep = new EncoderParameters();
                            //ep.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)100);
                            //bmp.Save(save_dialog.FileName, ici, ep);
                            bmp.Save(save_dialog.FileName, ImageFormat.Png);
                        } break;
                }
            }

            MessageBox.Show("De foto is succesvol opgeslagen.", "Klaar");
        }

        private void extractButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)fotoPicturebox.Image;

            if (bmp == null)
                return;

            string extractedText = SteganographyHelper.extractText(bmp);

            //if (encryptCheckBox.Checked)
            //{
            //    try
            //    {
            //        extractedText = Crypto.DecryptStringAES(extractedText, passwordTextBox.Text);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Wrong password", "Error");

            //        return;
            //    }
            //}

            messageTextBox.Text = extractedText;
        }

        private void Steganography_DragDrop(object sender, DragEventArgs e)
        {
            if (validData)
            {
                while (getImageThread.IsAlive)
                {
                    Application.DoEvents();
                    Thread.Sleep(0);
                }
                fotoPicturebox.Image = image;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Text Files|*.txt";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                messageTextBox.Text = File.ReadAllText(open_dialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileIO fileIO = new FileIO();
            string tekst = messageTextBox.Text;
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Text Files|*.txt";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                fileIO.Write(save_dialog.FileName, tekst);
            }
        }
    }
}
