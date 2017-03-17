using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSec04
{
    public class User
    {
        private int ID;
        private string name;
        private string surname;
        private string email;
        private string password;
        private string publickey;
        private string privateKey;

        public User()
        {

        }

        public int Id
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
                
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                
            }
        }

        public string PublicKey
        {
            get { return publickey; }
            set
            {
                publickey = value;

            }
        }

        public string PrivateKey
        {
            get { return privateKey; }
            set
            {
                privateKey = value;

            }
        }
    }
}
