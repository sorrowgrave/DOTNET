using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionZoneData
{
    public class Merk
    {
        public int Id { get; set; }
        public string MerkNaam { get; set; }

        public Merk(string merkNaam)
        {
            MerkNaam = merkNaam;
        }

        public Merk() { }
    }
}
