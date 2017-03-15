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
using System.Text.RegularExpressions;

namespace DrivingPXL
{
    //Form waar je je registreerd en informatie wordt doogestuurd
    //Author: Kenny Vanrusselt
    //Date: 25/04/2014 18:25
    public partial class Register : Form
    {
        string name;
        string surname;
        string email;
        string password;
        string rePassword;
        string birthDate;
        string land;
        string postalCode;
        string existingUser;
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        bool emptyField = false;

        Random random = new Random();
        


        public Register()
        {
       
            InitializeComponent();
            birthDatePicker.CustomFormat = "dd/MM/yyyy";
            sendingLabel.Visible = false;
            nextButton.BackColor = Color.FromArgb(1, 100, 139);
            cancelButton.BackColor = Color.FromArgb(1, 100, 139);
        }

        private void nextBtn_MouseHover(object sender, EventArgs e)
        {
            nextButton.BackColor = Color.FromArgb(11, 134, 168);
        }

        private void nextBtn_MouseLeave(object sender, EventArgs e)
        {
            nextButton.BackColor = Color.FromArgb(1, 100, 139);

        }

        private void cancelBtn_MouseHover(object sender, EventArgs e)
        {
            cancelButton.BackColor = Color.FromArgb(11, 134, 168);
        }

        private void cancelBtn_MouseLeave(object sender, EventArgs e)
        {
            cancelButton.BackColor = Color.FromArgb(1, 100, 139);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void returnLbl_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {

            int validationCode1 = random.Next(1000, 10000);
            int validationCode2 = random.Next(1000, 10000);
            Variables.validationCode = validationCode1 + "-" + validationCode2;


            try
            {
                errorUserExists.Clear();
                pwdMismatch.Clear();
                errorFieldEmpty.Clear();
                errorFormat.Clear();

                email = ((emailTextBox.Text + "@" + domainComboBox.Text).ToLower()).Trim(' ');
                surname = lastnTextBox.Text.Trim(' ');
                name = firstnTextBox.Text.Trim(' ');
                password = pwdTextBox.Text.Trim(' ');
                rePassword = rePwdTextBox.Text.Trim(' ');
                birthDate = birthDatePicker.Text;
                land = countryComboBox.Text;
                postalCode = postalCodeMaskedTextBox.Text;


                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox textBox = c as TextBox;
                        if (textBox.Text.Trim(' ') == string.Empty)
                        {
                            emptyField = true;
                            errorFieldEmpty.SetError(textBox, "Please, fill in this textbox.");
                        }
                    }
                    if (c is MaskedTextBox)
                    {
                        MaskedTextBox maskedTextBox = c as MaskedTextBox;
                        if (maskedTextBox.Text == string.Empty)
                        {
                            emptyField = true;
                            errorFieldEmpty.SetError(maskedTextBox, "Please, fill in this textbox.");
                        }
                    }
                }

                if (password != rePassword)
                {
                    pwdMismatch.SetError(pwdTextBox, "Passwords don't match!");
                    pwdMismatch.SetError(rePwdTextBox, "Passwords don't match!");
                    emptyField = true;

                }


                if (!Regex.IsMatch(email, pattern))
                {
                    throw new InvalidEmailException("Your email is invalid");
                }

                if (emptyField)
                {
                    emptyField = false;
                    return;
                }
                    




                Variables.path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\Users\\";

                if (!Directory.Exists(Variables.path))
                    Directory.CreateDirectory(Variables.path);

                foreach (string f in Directory.GetDirectories(Variables.path))
                {

                    existingUser = f.Remove(0, Variables.path.Length);

                    if (email == existingUser.ToLower())
                        throw new UserAlreadyExistsException("User already exists!");

                }

                sendingLabel.Visible = true;
                Cursor.Current = Cursors.WaitCursor;
                sendingLabel.Refresh();

                Variables.path = Variables.path + email;
                Variables.email = email;
                Variables.name = name;
                Variables.surname = surname;

                SendEmail Email = new SendEmail(Variables.validationCode, email, name, surname);

                CreateUser user = new CreateUser(name, surname, email, password, birthDate, land, postalCode, Variables.path);

                Validation validation = new Validation();
                validation.Show();
                this.Hide();
            }
            
            catch(InvalidEmailException ex)
            {
                errorFormat.SetError(domainComboBox, ex.Message);
            }
            catch (UserAlreadyExistsException ex)
            {
                errorUserExists.SetError(domainComboBox, ex.Message);
            }
            catch (NoNetworkException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void postalCodeMaskedTextBox_Click(object sender, EventArgs e)
        {
            postalCodeMaskedTextBox.SelectionStart = 0;
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
