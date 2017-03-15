using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionZoneData
{
    public class BestellingDB
    {

        private static ObservableCollection<Bestelling> bestellingen;
        FashionZoneDB fashionZoneDB;

        public BestellingDB()
        {
            bestellingen = new ObservableCollection<Bestelling>();
            fashionZoneDB = new FashionZoneDB();
            FillBestellingenList("SELECT Id, Bonnr, BestelDatum, Merk, LeverDatum, OntvangenOp, Afgerond, TotAKPrijs, TotVKPrijs From tblBestellingen");
        }

        public void AddBestelling(Bestelling newBestelling)
        {
            bestellingen.Add(newBestelling);

            string stmt = "INSERT INTO tblBestellingen (Bonnr, BestelDatum, Merk, LeverDatum, OntvangenOp, Afgerond, TotAKPrijs, TotVKPrijs) " +
                "VALUES('" + newBestelling.BonNummer + "', '" + newBestelling.BestelDatum + "', '" + newBestelling.Merk + "', '" + newBestelling.LeverDatum +
                "', '" + newBestelling.OntvangenOp + "', " + newBestelling.Afgerond + ", " + newBestelling.TotAKPrijs + ", " + newBestelling.TotVKPrijs + ")";

            fashionZoneDB.updateTable(stmt);
        }

        public void FillBestellingenList(string stmt)
        {
            foreach (DataRow row in fashionZoneDB.selectTable(stmt).Rows)
            {
                Bestelling bestelling = new Bestelling();
                bestelling.Id = int.Parse(row[0].ToString());
                bestelling.BonNummer = row[1].ToString();
                bestelling.BestelDatum = row[2].ToString();
                bestelling.Merk = row[3].ToString();
                bestelling.LeverDatum = row[4].ToString();
                bestelling.OntvangenOp = row[5].ToString();
                bestelling.Afgerond = bool.Parse(row[6].ToString());
                bestelling.TotAKPrijs = decimal.Parse(row[7].ToString());
                bestelling.TotVKPrijs = decimal.Parse(row[8].ToString());
                bestellingen.Add(bestelling);
            }
        }

        public ObservableCollection<Bestelling> GetBestellingList()
        {
            return bestellingen;
        }

        public void UpdateRow(Bestelling bestelling)
        {
            int index = bestellingen.IndexOf(bestelling);
            bestellingen[index] = bestelling;

            string stmt = "UPDATE tblBestellingen " +
                "SET Bonnr='" + bestelling.BonNummer + "', BestelDatum='" + bestelling.BestelDatum + "', LeverDatum='" + bestelling.LeverDatum + "', Merk='" + bestelling.Merk + "', OntvangenOp='" + bestelling.OntvangenOp +
                "', Afgerond=" + bestelling.Afgerond + ", TotAKPrijs=" + bestelling.TotAKPrijs.ToString().Replace(",", ".") + ", TotVKPrijs=" + bestelling.TotVKPrijs.ToString().Replace(",", ".") +
                " WHERE Id=" + bestelling.Id + ";";

            fashionZoneDB.updateTable(stmt);
        }

        public void UpdatePrijs(Bestelling bestelling)
        {
            int index = bestellingen.IndexOf(bestelling);
            bestellingen[index] = bestelling;

            string stmt = "UPDATE tblBestellingen " +
                "SET  TotAKPrijs=" + bestelling.TotAKPrijs.ToString().Replace(",", ".") + ", TotVKPrijs=" + bestelling.TotVKPrijs.ToString().Replace(",", ".") +
                " WHERE Id=" + bestelling.Id + ";";

            fashionZoneDB.updateTable(stmt);
        }

        public void DeleteArtikel(Bestelling bestelling)
        {
            int index = bestellingen.IndexOf(bestelling);
            bestellingen.RemoveAt(index);

            string stmt = "DELETE FROM tblBestellingen " +
                "WHERE Id=" + bestelling.Id + ";";

            fashionZoneDB.updateTable(stmt);
        }
    }
}
