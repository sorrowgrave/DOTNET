using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionZoneData
{
    public class ArtikelDB
    {
        private ObservableCollection<Artikel> artikels;

        FashionZoneDB fashionZoneDB;
        public decimal TotAKPrijs { get; set; }
        public decimal TotVKPrijs { get; set; }

        public ArtikelDB()
        {
            fashionZoneDB = new FashionZoneDB();
            TotAKPrijs = 0;
            TotVKPrijs = 0;
            FillArtikelsList("SELECT Id, Artikelnr, Merk, Artikelnaam, Categorie, Datum, Kleur, AKprijs, VKprijs, Aantal, Bonnr, TotAKprijs, TotVKprijs, Afgerond From tblGegevens");
        }

        public ObservableCollection<Artikel> GetArtikelsList()
        {
            return artikels;
        }

        public ObservableCollection<Artikel> FillArtikelsList(string statement)
        {
            artikels = new ObservableCollection<Artikel>();

            foreach (DataRow row in fashionZoneDB.selectTable(statement).Rows)
            {
                Artikel artikel = new Artikel();
                artikel.Id = int.Parse(row[0].ToString());
                artikel.Artikelnr = row[1].ToString();
                artikel.Merk = row[2].ToString();
                artikel.Artikelnaam = row[3].ToString();
                artikel.Categorie = row[4].ToString();
                artikel.Datum = row[5].ToString();
                artikel.Kleur = row[6].ToString();
                artikel.AKprijs = decimal.Parse(row[7].ToString());
                artikel.VKprijs = decimal.Parse(row[8].ToString());
                artikel.Aantal = byte.Parse(row[9].ToString());
                artikel.Bonnr = row[10].ToString();
                artikel.TotAKprijs = decimal.Parse(row[11].ToString());
                artikel.TotVKprijs = decimal.Parse(row[12].ToString());
                artikel.Afgerond = bool.Parse(row[13].ToString());
                artikels.Add(artikel);
                TotAKPrijs += artikel.TotAKprijs;
                TotVKPrijs += artikel.TotVKprijs;
            }

            return artikels;
        }

        public void AddArtikel(Artikel artikel)
        {
            artikels.Add(artikel);

            string stmt = "INSERT INTO tblGegevens (Artikelnr, Merk, Artikelnaam, Categorie, Datum, Kleur, AKprijs, VKprijs, Aantal, Bonnr, TotAKprijs, TotVKprijs, Afgerond) " +
                "VALUES('" + artikel.Artikelnr + "', '" + artikel.Merk + "', '" + artikel.Artikelnaam +
                "', '" + artikel.Categorie + "', '" + artikel.Datum + "', '" + artikel.Kleur + "', " +
                artikel.AKprijs.ToString().Replace(",", ".") + ", " + artikel.VKprijs.ToString().Replace(",", ".") + ", " + artikel.Aantal + ", '" + artikel.Bonnr
                + "', " + artikel.TotAKprijs.ToString().Replace(",", ".") + ", " + artikel.TotVKprijs.ToString().Replace(",", ".") + ", " + artikel.Afgerond + ")";

            fashionZoneDB.updateTable(stmt);
        }

        public void UpdateRow(Artikel artikel)
        {
            int index = artikels.IndexOf(artikel);
            artikels[index] = artikel;

            string stmt = "UPDATE tblGegevens " +
                "SET Artikelnr='" + artikel.Artikelnr + "', Merk='" + artikel.Merk + "', Artikelnaam='" + artikel.Artikelnaam + "', Categorie='" + artikel.Categorie +
                "', Datum='" + artikel.Datum + "', Kleur='" + artikel.Kleur + "', AKprijs=" + artikel.AKprijs.ToString().Replace(",", ".") + ", VKprijs=" + artikel.VKprijs.ToString().Replace(",",".") + 
                ", Aantal=" + artikel.Aantal + ", Bonnr='" + artikel.Bonnr + "', TotAKprijs=" + artikel.TotAKprijs.ToString().Replace(",", ".") +
                ", TotVKprijs=" + artikel.TotVKprijs.ToString().Replace(",", ".") + ", Afgerond=" + artikel.Afgerond + " WHERE Id="+artikel.Id+";";

            fashionZoneDB.updateTable(stmt);
        }

        public void DeleteArtikel(Artikel artikel)
        {
            int index = artikels.IndexOf(artikel);
            artikels.RemoveAt(index);

            string stmt = "DELETE FROM tblGegevens " +
                "WHERE Id=" + artikel.Id + ";";

            fashionZoneDB.updateTable(stmt);
        }
    }
}
