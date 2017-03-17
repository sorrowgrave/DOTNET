using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicSec04
{

    public partial class ChoiceMenu : Form
    {
        User user;
        string choice;
        public ChoiceMenu()
        {
            InitializeComponent();

        }

        public ChoiceMenu(User user, string choice)
        {
            InitializeComponent();
            this.choice = choice;
            this.user = user;
        }

        private void ChoiceMenu_Load(object sender, EventArgs e)
        {
            if (choice != "encrypt")
            {
                questionLabel.Text = "What would you like to decrypt?";
            }
        }
        private void encryptMessage_Click(object sender, EventArgs e)
        {

                EncryptMessage encryptMessage = new EncryptMessage(user);
                encryptMessage.ShowDialog();
                this.Close();

        }

        private void encryptFile_Click(object sender, EventArgs e)
        {

            if (choice == "encrypt")
            {
                EncryptFile encryptFile = new EncryptFile(user);
                encryptFile.ShowDialog();
                this.Close();
            }
            else
            {
                DecryptFile decryptFile = new DecryptFile(user);          
                decryptFile.ShowDialog();
                this.Close();
                
            }
        }

        private void exitLabel_Click(object sender, EventArgs e)
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
