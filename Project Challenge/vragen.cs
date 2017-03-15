using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DrivingPXL
{
    //Klasse waar de vragen in een array worden gezet.
    //Author: Niels Carmans
    //Date: 24/04/2014 20:35
    class vragen
    {
        public static int MAX = 52;
        public string[][] allLines = new string [MAX][];
        public string lijn;
        public string picture;
        int nummer;

        public int Nummer
        {
            set
            {
                nummer = value;
            }
        }
       
        public string Picture
        {
            get
            {
                picture = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\Misc\\1\\" + allLines[nummer][0].Substring(0, 3) + ".jpg";
                return picture;

            }
        }


        public vragen()
        {
            
        }

        public string[][] stelVraag(string path)
        {
            //vragen in een array zetten

            using (StreamReader sr = File.OpenText(path))
            {
                
                int x = 0;
                while (!sr.EndOfStream)
                {
                    lijn = sr.ReadLine();
                    if (lijn != "")
                    {
                        allLines[x] = lijn.Split(';');
                    }
                    x += 1;
                }
            }
            
            return allLines;
        }
      
    }
}
