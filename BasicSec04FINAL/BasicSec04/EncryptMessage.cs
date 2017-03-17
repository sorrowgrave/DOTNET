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
    public partial class EncryptMessage : Form
    {
        User user;
        private byte[] passwordBytes = {0,0,0,0,0,0,0,0};
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
        public EncryptMessage()
        {
            InitializeComponent();
        }

        public EncryptMessage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Encrypt_Load(object sender, EventArgs e)
        {
            usersComboBox.DataSource = UserDB.getUserNames();
            usersComboBox.DisplayMember = "Name";
            usersComboBox.ValueMember = "Id";
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text;

            string publicKey = System.Text.Encoding.Default.GetString(UserDB.GetPublicKey(Convert.ToInt32(usersComboBox.SelectedValue.ToString())));
            rsa.FromXmlString(publicKey);

            byte[] secretMessage = Encoding.UTF8.GetBytes(message);

            //byte[] encrypted = AESEncryption.AES_Encrypt(secretMessage, passwordBytes);

            byte[] encrypted = rsa.Encrypt(secretMessage, true);

            MessageBox.Show(user.PrivateKey);

            encryptedTextBox.Text = Convert.ToBase64String(encrypted); 

        }

        private void decryptButton_Click(object sender, EventArgs e)
        {

            byte[] encrypted = Convert.FromBase64String(encryptedTextBox.Text); 

            //byte[] decrypted = AESEncryption.AES_Decrypt(encrypted, passwordBytes);

            string publicKey = System.Text.Encoding.Default.GetString(UserDB.GetPublicKey(Convert.ToInt32(usersComboBox.SelectedValue.ToString())));

            rsa.FromXmlString(user.PrivateKey);

            byte[] decryptedBytes = rsa.Decrypt(encrypted, true);

            MessageBox.Show(publicKey);

            encryptedTextBox.Text = Encoding.UTF8.GetString(decryptedBytes);       

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
