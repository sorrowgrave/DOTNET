using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace BasicSec04
{
  
    public partial class Menu : Form, UserInterface
    {
        User user;

        public Menu(User user)
        {
            InitializeComponent();
            this.user = user;

            changePictureLabel.ForeColor = Color.FromArgb(45, 45, 48);
            signOutLabel.ForeColor = Color.FromArgb(45, 45, 48);
            exitLabel.ForeColor = Color.FromArgb(45, 45, 48);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.MouseClick += Menu_MouseHover;
            ShowUserName();
            ShowTime();
            ShowPicture();          
        }

        public void ShowUserName()
        {
            usernameLabel.Text = user.Name;
        }
        public void ShowTime()
        {
            tijdTimer.Start();
        }
        public void ShowPicture()
        {
            //string[] pictureData = File.ReadAllLines(Variables.path + "\\userData.txt");
            //if (pictureData.Length > 1)
            //{
            //    Image profilePic = Image.FromFile(pictureData[1]);
            //    profilePictureBox.Image = profilePic;
            //    profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //}
        }


        private void tijdTimer_Tick(object sender, EventArgs e)
        {
            tijdLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void sluitLabel_MouseHover(object sender, EventArgs e)
        {
            closeLabel2.Show();  
        }

        private void closeLabel2_MouseLeave(object sender, EventArgs e)
        {
            closeLabel2.Hide();
        }

        private void closeLabel2_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void minimizeLabel_MouseHover(object sender, EventArgs e)
        {
            minimizeLabel.Show();
        }

        private void minimizeLabel2_MouseLeave(object sender, EventArgs e)
        {
            minimizeLabel.Hide();
        }

        private void minimizeLabel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void expandLabel_MouseHover(object sender, EventArgs e)
        {
            expandLabel.Show();
        }

        private void expandLabel2_MouseLeave(object sender, EventArgs e)
        {
            expandLabel.Hide();
        }

        private void expandLabel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
                this.WindowState = FormWindowState.Maximized;
        }


        private void profilePictureBox_Click(object sender, EventArgs e)
        {
            signOutLabel.Visible = true;
            changePictureLabel.Visible = true;
            exitLabel.Visible = true;
        }

        private void changePictureLabel_MouseHover(object sender, EventArgs e)
        {
            changePictureLabel.BackColor = Color.FromArgb(45, 45, 48);
            changePictureLabel.ForeColor = Color.White;
        }

        private void changePictureLabel_MouseLeave(object sender, EventArgs e)
        {
            changePictureLabel.BackColor = Color.White;
            changePictureLabel.ForeColor = Color.FromArgb(45, 45, 48);
        }

        private void signOutLabel_MouseHover(object sender, EventArgs e)
        {
            signOutLabel.BackColor = Color.FromArgb(45, 45, 48);
            signOutLabel.ForeColor = Color.White;
        }

        private void signOutLabel_MouseLeave(object sender, EventArgs e)
        {
            signOutLabel.BackColor = Color.White;
            signOutLabel.ForeColor = Color.FromArgb(45, 45, 48);
        }

        private void exitLabel_MouseHover(object sender, EventArgs e)
        {
            exitLabel.BackColor = Color.FromArgb(45, 45, 48);
            exitLabel.ForeColor = Color.White;
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.BackColor = Color.White;
            exitLabel.ForeColor = Color.FromArgb(45, 45, 48);
        }
        private void signOutLabel_Click(object sender, EventArgs e)
        {
            Login login = new Login(user);
            login.Show();
            this.Close();
        }
        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changePictureLabel_Click(object sender, EventArgs e)
        {
            //setOptionLabelsInvisible();

            //string startdir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            //openFileDialog.InitialDirectory = startdir;
            //openFileDialog.Filter = "Image Files|*.BMP;" + "*.JPG;*.GIF|All files (*.*)|*.*";


            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        Image profilePic = Image.FromFile(openFileDialog.FileName);
            //        profilePictureBox.Image = profilePic;

            //        profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            //        FileStream userData = new FileStream(Variables.path + "\\userData.txt", FileMode.Open, FileAccess.Write);
            //        userData.Close();


            //        string[] gegevens = File.ReadAllLines(Variables.path + "\\userData.txt");
            //        if(gegevens.Length > 1)
            //        {
            //            gegevens[1] = openFileDialog.FileName;
            //            File.WriteAllLines(Variables.path + "\\userData.txt", gegevens);
            //        }
            //        else
            //        {
            //            using (StreamWriter sw = File.AppendText(Variables.path + "\\userData.txt"))
            //            {
            //                sw.WriteLine(openFileDialog.FileName);
            //            }	
            //        }

            //    }
            //    catch(System.OutOfMemoryException)
            //    {
            //        MessageBox.Show("Cannot change picture, file is not an image.");
            //    }
            //    catch(FileNotFoundException){
            //        MessageBox.Show("User does not exist.");
            //        Login login = new Login();
            //        login.Show();
            //        this.Close();
            //    }


            //}
        }

        private void Menu_MouseHover(object sender, EventArgs e)
        {
            if (changePictureLabel.Visible && exitLabel.Visible  && signOutLabel.Visible )
            {
                setOptionLabelsInvisible();
            }
        }

        public void setOptionLabelsInvisible()
        {
            changePictureLabel.Visible = false;
            exitLabel.Visible = false;
            signOutLabel.Visible = false;
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            ChoiceMenu choiceMenu = new ChoiceMenu(user, "encrypt");
            choiceMenu.ShowDialog();
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            ChoiceMenu choiceMenu = new ChoiceMenu(user, "decrypt");
            choiceMenu.ShowDialog();
        }
        //Borderless window verplaatsen

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void SteganographyButton_Click(object sender, EventArgs e)
        {
            Steganography steganography = new Steganography();
            steganography.Show();
        }

    }
}
