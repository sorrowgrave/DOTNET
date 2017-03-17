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
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace BasicSec04
{

    public partial class Login : Form, UserInterface
    {
        User user;
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BasicSecurity\\Users\\";

        public Login()
        {
            InitializeComponent();       
        }

        public Login(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            emailTextBox.ForeColor = Color.FromArgb(45, 45, 48);
            pwdTextBox.ForeColor = Color.FromArgb(45, 45, 48);

            ShowTime();

            if (user != null)
            {
                usernameLabel.Text = user.Name;
                emailTextBox.Text = user.Email;
            }

            if (emailTextBox.Text != "")
            {
                this.ActiveControl = emailTextBox;
                this.ActiveControl = pwdTextBox;
            }


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
            //ms = new MemoryStream(User.Picture);
            //Image returnImage = Image.FromStream(ms);
            //profilePictureBox.Image = returnImage;
            //profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void pwdTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                login();
                e.Handled = e.SuppressKeyPress = true;
            }
        }


        private void cntnLbl_Click(object sender, EventArgs e)
        {
            login();
        }


        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            emailTextBox.Text = emailTextBox.Text.Trim(' ');

            if (!(emailTextBox.Text == string.Empty))
                pwdTextBox.Visible = true;

            string email = emailTextBox.Text.Trim(' ');


            try
            {
                user = new User();
                user = UserDB.GetUser(email);

                if (user == null)
                    errorNoneExistant.SetError(emailTextBox, "Opgepast! Gebruiker niet gevonden");
                else
                {
                    usernameLabel.Text = user.Name;
                    ShowPicture();
                    errorNoneExistant.Clear();
                }



            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        public void getPrivateKey()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BasicSecurity\\Users\\";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            if (!File.Exists(path + user.Email + ".xml"))
                throw new FileNotFoundException("File not exists: " + path + user.Email);

            try
            {
                user.PrivateKey = File.ReadAllText(path + user.Email + ".xml");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception occurred at LoadPrivateFromXml()\nMessage: " + ex.Message);
                throw ex;
            }
        }
        public void login()
        {


            errorFieldEmpty.Clear();

            string password = pwdTextBox.Text;


            bool emptyField = false;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        emptyField = true;
                        if (textBox.Name == emailTextBox.Name)
                        {
                            errorFieldEmpty.SetError(textBox, "Vergeet je email niet in te vullen.");
                        }
                        else
                        {
                            errorFieldEmpty.SetError(textBox, "Vergeet je wachtwoord niet in te vullen");
                        }

                    }
                }
            }

            if (emptyField)
                return;

            if (user == null)
            {
                errorNoneExistant.SetError(emailTextBox, "Gebruiker niet gevonden");
                return;
            }


            if (pwdTextBox.Text != user.Password)
            {
                pwdTextBox.Focus();
                pwdTextBox.Clear();
                errorWrongPass.SetError(emailTextBox, "Onjuist wachtwoord");
                return;
            }
            else
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                if (!File.Exists(path + user.Email.ToLower() + ".xml" ))
                {
                    RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);

                    FileIO writefile = new FileIO();
                    writefile.Write(path + user.Email.ToLower() + ".xml", rsa.ToXmlString(true));


                    byte[] publicKey = System.Text.Encoding.Default.GetBytes(rsa.ToXmlString(false));

                    UserDB.addUserPublicKey(user.Email, publicKey);
                }

                getPrivateKey();
                Menu menu = new Menu(user);
                menu.Show();
                this.Hide();
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(emailTextBox.Text == string.Empty))
            {
                pwdTextBox.Visible = true;
                pwdWatermarkLabel.Visible = true;
                requestAccountLabel.Visible = true;
                recoveryLabel.Visible = true;
                continueLabel.Visible = true;
            }
            else
            {
                pwdTextBox.Visible = false;
                pwdWatermarkLabel.Visible = false;
                requestAccountLabel.Visible = false;
                recoveryLabel.Visible = false;
                continueLabel.Visible = false;
            }
        }
        private void pwdTextBox_Enter(object sender, EventArgs e)
        {
            pwdWatermarkLabel.Visible = false;
        }
        private void pwdTextBox_Leave(object sender, EventArgs e)
        {
            if (pwdTextBox.Text == "")
                pwdWatermarkLabel.Visible = true;
        }



        private void exitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tijdTimer_Tick(object sender, EventArgs e)
        {
            tijdLabel.Text = DateTime.Now.ToString("HH:mm:ss");
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

        private void pwdWatermarkLabel_Click(object sender, EventArgs e)
        {
            pwdWatermarkLabel.Visible = false;
            pwdTextBox.Focus();
        }

        private void recoveryLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void requestAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

    }
}
