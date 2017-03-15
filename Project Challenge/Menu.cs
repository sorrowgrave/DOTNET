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

namespace DrivingPXL
{
    //Een form waarmee je naar de andere subforms kan gaan(hoofdmenu).
    //Date: 18/04/2014 15:51
    //Author: Kenny Vanrusselt
    public partial class Menu : Form, UserInterface
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.MouseClick += Menu_MouseHover;
            showUserName();
            showTime();
            showProfilePicture();          
        }

        public void showUserName()
        {
            usernameLbl.Text = Variables.name;
        }
        public void showTime()
        {
            timerTijd.Start();
        }
        public void showProfilePicture()
        {
            string[] pictureData = File.ReadAllLines(Variables.path + "\\userData.txt");
            if (pictureData.Length > 1)
            {
                Image profilePic = Image.FromFile(pictureData[1]);
                profilePictureBox.Image = profilePic;
                profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void oefenButton_Click(object sender, EventArgs e)
        {
            OefenExamen oefenexamen = new OefenExamen();
            this.Hide();
            oefenexamen.Show();
            
        }

        private void gamesBtn_Click(object sender, EventArgs e)
        {
            Games games = new Games();
            games.Show();
            this.Close();
        }


        private void timerTijd_Tick(object sender, EventArgs e)
        {
            tijdLbl.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void sluitLbl_MouseHover(object sender, EventArgs e)
        {
            sluitLbl2.Show();  
        }

        private void sluitLbl2_MouseLeave(object sender, EventArgs e)
        {
            sluitLbl2.Hide();
        }

        private void sluitLbl2_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void minLbl_MouseHover(object sender, EventArgs e)
        {
            minLbl2.Show();
        }

        private void minLbl2_MouseLeave(object sender, EventArgs e)
        {
            minLbl2.Hide();
        }

        private void minLbl2_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void plusLbl_MouseHover(object sender, EventArgs e)
        {
            plusLbl2.Show();
        }

        private void plusLbl2_MouseLeave(object sender, EventArgs e)
        {
            plusLbl2.Hide();
        }

        private void plusLbl2_MouseClick(object sender, MouseEventArgs e)
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
            changePictureLabel.BackColor = Color.Transparent;
            changePictureLabel.ForeColor = Color.White;
        }

        private void changePictureLabel_MouseLeave(object sender, EventArgs e)
        {
            changePictureLabel.BackColor = Color.White;
            changePictureLabel.ForeColor = Color.Black;
        }

        private void signOutLabel_MouseHover(object sender, EventArgs e)
        {
            signOutLabel.BackColor = Color.Transparent;
            signOutLabel.ForeColor = Color.White;
        }

        private void signOutLabel_MouseLeave(object sender, EventArgs e)
        {
            signOutLabel.BackColor = Color.White;
            signOutLabel.ForeColor = Color.Black;
        }

        private void exitLabel_MouseHover(object sender, EventArgs e)
        {
            exitLabel.BackColor = Color.Transparent;
            exitLabel.ForeColor = Color.White;
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.BackColor = Color.White;
            exitLabel.ForeColor = Color.Black;
        }
        private void signOutLabel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changePictureLabel_Click(object sender, EventArgs e)
        {
            setOptionLabelsInvisible();

            string startdir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.InitialDirectory = startdir;
            openFileDialog.Filter = "Image Files|*.BMP;" + "*.JPG;*.GIF|All files (*.*)|*.*";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image profilePic = Image.FromFile(openFileDialog.FileName);
                    profilePictureBox.Image = profilePic;

                    profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    FileStream userData = new FileStream(Variables.path + "\\userData.txt", FileMode.Open, FileAccess.Write);
                    userData.Close();


                    string[] gegevens = File.ReadAllLines(Variables.path + "\\userData.txt");
                    if(gegevens.Length > 1)
                    {
                        gegevens[1] = openFileDialog.FileName;
                        File.WriteAllLines(Variables.path + "\\userData.txt", gegevens);
                    }
                    else
                    {
                        using (StreamWriter sw = File.AppendText(Variables.path + "\\userData.txt"))
                        {
                            sw.WriteLine(openFileDialog.FileName);
                        }	
                    }

                }
                catch(System.OutOfMemoryException)
                {
                    MessageBox.Show("Cannot change picture, file is not an image.");
                }
                catch(FileNotFoundException){
                    MessageBox.Show("User does not exist.");
                    Login login = new Login();
                    login.Show();
                    this.Close();
                }


            }
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

        private void resultatenBtn_Click(object sender, EventArgs e)
        {
            Results results = new Results();
            results.Show();
            this.Close();
        }

        private void examenBtn_Click(object sender, EventArgs e)
        {
            Variables.examen = true;
            OefenExamen oefenexamen = new OefenExamen();
            this.Hide();
            oefenexamen.Show();
        }
    }
}
