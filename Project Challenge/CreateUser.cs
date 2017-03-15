using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DrivingPXL
{
    //Form voor het aanmaken van users en wegschrijven naar tekstfile.
    //Date: 29/04/2014 04:20
    //Author: Kenny Vanrusselt
    class CreateUser
    {
        private string naam;
        private string voornaam;
        private string email;
        private string passwoord;
        private string geboorteDatum;
        private string land;
        private string postcode;
        private string path;

        public CreateUser(string naam, string voornaam, string email, string passwoord, string geboorteDatum, string land, string postcode, string path)
        {
            this.naam = naam;
            this.voornaam = voornaam;
            this.email = email;
            this.passwoord = passwoord;
            this.geboorteDatum = geboorteDatum;
            this.land = land;
            this.postcode = postcode;
            this.path = path;

            Directory.CreateDirectory(path);
          
            FileStream userData = new FileStream(path + "\\userData.txt", FileMode.OpenOrCreate, FileAccess.Write);
            userData.Close();
            StreamWriter writer = File.CreateText(path + "\\userData.txt");
            
            writer.WriteLine(naam + ";" + voornaam + ";" + email + ";" + passwoord + ";" + geboorteDatum + ";" + land + ";" + postcode);
           
            writer.Close();    

        }

    }
}
