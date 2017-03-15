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
    //Klasse die de email valideerd.
    //Author: Kenny Vanrusselt
    //Date: 30/04/2014 20:16
    public partial class Validation : Form
    {
        public Validation()
        {
            InitializeComponent();
            receipentLabel.Text = "A confirmation email has been sent to: " + Variables.email;
            sendingLabel.Visible = false;
            finishButton.BackColor = Color.FromArgb(1, 100, 139);
            cancelButton.BackColor = Color.FromArgb(1, 100, 139);
            resendButton.BackColor = Color.FromArgb(1, 100, 139);
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("If you cancel now, your data will be lost. \nAre you sure you want to continue?", "Warning!",  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(confirmation == DialogResult.Yes)
            {
                Directory.Delete(Variables.path, true);
               
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            validationMaskedTextBox.PromptChar = Convert.ToChar(" ");
            
            // check the last part of string
            if (validationMaskedTextBox.Text.Substring(5).Trim() != "")
            {
                validationMaskedTextBox.Mask = "0000-0000";
                validationMaskedTextBox.SelectionStart = 4;
            }
            else // check the middle part of string
            {
                validationMaskedTextBox.Mask = "0000 0000";
            }

        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            if (validationMaskedTextBox.Text == Variables.validationCode)
            {
                MessageBox.Show("Thank you for your registration.");
                Login login = new Login();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("The code you have entered is not valid.");
                validationMaskedTextBox.Clear();
                validationMaskedTextBox.Focus();
            }

        }
        private void finishBtn_MouseHover(object sender, EventArgs e)
        {
            finishButton.BackColor = Color.FromArgb(11, 134, 168);
        }

        private void finishBtn_MouseLeave(object sender, EventArgs e)
        {
            finishButton.BackColor = Color.FromArgb(1, 100, 139);
        }

        private void cancelBtn_MouseHover(object sender, EventArgs e)
        {
            cancelButton.BackColor = Color.FromArgb(11, 134, 168);
        }

        private void cancelBtn_MouseLeave(object sender, EventArgs e)
        {
            cancelButton.BackColor = Color.FromArgb(1, 100, 139);
        }
        private void resendButton_MouseHover(object sender, EventArgs e)
        {
            resendButton.BackColor = Color.FromArgb(11, 134, 168);
        }
        private void resendButton_MouseLeave(object sender, EventArgs e)
        {
            resendButton.BackColor = Color.FromArgb(1, 100, 139);
        }


        private void resendButton_Click(object sender, EventArgs e)
        {
            sendingLabel.Visible = true;
            sendingLabel.Refresh();
            Cursor.Current = Cursors.WaitCursor;
            SendEmail Email = new SendEmail(Variables.validationCode, Variables.email, Variables.name, Variables.surname);
            sendingLabel.Visible = false;
            Cursor.Current = Cursors.WaitCursor;
            MessageBox.Show("A new email has been sent.");
        }

    }
}
