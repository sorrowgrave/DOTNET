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
namespace DrivingPXL
{
    //Form voor het inloggen.
    //Date: 21/04/2014 18:45
    //Author: Kenny Vanrusselt
    public partial class Login : Form, UserInterface
    {
        private int iScroll = 0;
        private string creditString = "                           Credits to: Niels Carmans,  Lars Hoho,  Olivier Quaethoven && Kenny Vanrusselt  @ PXL Hasselt  2013-2014                        ";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            showTime();
            usernTextBox.Text = Variables.email;

            if (usernTextBox.Text != "")
            {
                this.ActiveControl = usernTextBox;
                this.ActiveControl = pwdTextBox;
            }
        }

        public void showUserName()
        {
            usernameLabel.Text = Variables.name;
        }
        public void showTime()
        {
            tijdTimer.Start();

        }

        public void showProfilePicture()
        {
            string[] pictureData = File.ReadAllLines(Variables.path + "\\userData.txt");
            if (pictureData.Length > 1)
            {
                Image profilePic = Image.FromFile(pictureData[1]);
                profilePictureBox.Image = profilePic;
                profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                return;
            }
        }

        private void tijdTimer_Tick(object sender, EventArgs e)
        {
            tijdLbl.Text = DateTime.Now.ToString("HH:mm:ss");

            iScroll = iScroll + 1;

            int iLimit = creditString.Length - iScroll;

            if (iLimit < 24)
            {
                iScroll = 0;
            }


            string newCreditString = creditString.Substring(iScroll, 24);
            creditsLabel.Text = newCreditString;
        }


        private void pwdTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                login();         
            }
        }

        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void cntnLbl_Click(object sender, EventArgs e)
        {
            login();
        }


        private void usernTextBox_Leave(object sender, EventArgs e)
        {
            try
            {

                usernTextBox.Text = usernTextBox.Text.Trim(' ');
                if (!(usernTextBox.Text == string.Empty))
                    pwdTextBox.Visible = true;

                Variables.path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\Users\\";

                string existingUser;
                string username = usernTextBox.Text.ToLower().Trim(' ');

                if (!Directory.Exists(Variables.path))
                    Directory.CreateDirectory(Variables.path);

                foreach (string f in Directory.GetDirectories(Variables.path))
                {

                    existingUser = f.Remove(0, Variables.path.Length);


                    if (username == existingUser.ToLower())
                    {

                        Variables.path = Variables.path + username;

                        FileStream fstream = new FileStream(Variables.path + "\\userData.txt", FileMode.Open, FileAccess.Read);
                        StreamReader reader = new StreamReader(fstream);

                        string gegevens = reader.ReadLine();
                        string[] data = gegevens.Split(';');

                        Variables.name = data[0];
                        Variables.surname = data[1];
                        Variables.email = data[2];
                        Variables.password = data[3];
                        Variables.birthDate = data[4];
                        Variables.postalCode = data[6];

                        reader.Close();

                        showUserName();
                        showProfilePicture();

                        break;
                    }
                    else
                        usernameLabel.Text = "User";


                }
            }catch(FileNotFoundException){
                Directory.Delete(Variables.path, true);
                Variables.password = "";
                Variables.name = "";
                Variables.email = "";
                Variables.surname = "";
                Variables.postalCode = "";
                Variables.birthDate = "";
                usernameLabel.Text = "User";
                MessageBox.Show("User not found, try registering again.");
            }
        }

        public void login()
        {
            errorFieldEmpty.Clear();
            string password = pwdTextBox.Text;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\Users\\";

            bool emptyField = false;
            bool invalidUser = false;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        emptyField = true;
                        if(textBox.Name == usernTextBox.Name)
                        {
                            errorFieldEmpty.SetError(textBox, "Please, fill in your username.");
                        }
                        else
                        {
                            errorFieldEmpty.SetError(textBox, "Please, fill in your password.");
                        }
                        
                    }
                }
            }

            if (emptyField)
                return;

            if (invalidUser || pwdTextBox.Text != Variables.password)
            {      
                pwdTextBox.Focus();
                pwdTextBox.Clear();
                errorWrongPass.SetError(usernTextBox, "Invalid username or password");
                return;
            }
               
            else
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
        }

        private void usernTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(usernTextBox.Text == string.Empty))
            {
                pwdTextBox.Visible = true;
                pwdWatermarkLabel.Visible = true;
                passRecoveryLabel.Visible = true;
                cntnLbl.Visible = true;
                registerLabel.Top = 274;
            }
            else
            {
                pwdTextBox.Visible = false;
                pwdWatermarkLabel.Visible = false;
                passRecoveryLabel.Visible = false;
                cntnLbl.Visible = false;
                registerLabel.Top = 243;
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

        private void passRecoveryLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (usernTextBox.Text.Trim(' ') != "")
            {
                Cursor.Current = Cursors.WaitCursor;
                sendingLabel.Visible = true;
                sendingLabel.Refresh();
                SendEmail Email = new SendEmail(Variables.password, Variables.email, Variables.name, Variables.surname, "Recovery");
                sendingLabel.Visible = false;
                Cursor.Current = Cursors.Default;
                MessageBox.Show("An email containing your password has been sent");               
                pwdTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Please enter your email address in the textbox first.");
                usernTextBox.Focus();
            }
                           
        }

        private void exitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
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


    }
}
