using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionZoneData
{
    public class Bestelling
    {
        public int Id { get; set; }
        public string BonNummer { get; set; }
        public string BestelDatum { get; set; }
        public string Merk { get; set; }
        public string LeverDatum { get; set; }
        public string OntvangenOp { get; set; }
        public bool Afgerond { get; set; }
        public decimal TotAKPrijs { get; set; }
        public decimal TotVKPrijs { get; set; }

        public Bestelling(string BonNummer, string BestelDatum, string Merk, string LeverDatum)
        {
            this.BonNummer = BonNummer;
            this.BestelDatum = BestelDatum;
            this.Merk = Merk;
            this.LeverDatum = LeverDatum;
            this.TotAKPrijs = 0;
            this.TotVKPrijs = 0;
            this.Afgerond = false;
            this.OntvangenOp = "Nog niet";
        }

        public Bestelling()
        { }
    }
}
