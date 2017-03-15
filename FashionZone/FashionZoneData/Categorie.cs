using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionZoneData
{
    public class Categorie
    {
        public int Id { get; set; }
        public string CategorieNaam { get; set; }

        public Categorie(string categorie)
        {
            CategorieNaam = categorie;
        }

        public Categorie() { }
    }
}
