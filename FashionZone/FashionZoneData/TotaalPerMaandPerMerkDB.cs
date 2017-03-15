using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionZoneData
{
    public class TotaalPerMaandPerMerkDB
    {
        private ObservableCollection<TotaalPerMaandPerMerk> totaalPerMaandPerMerken;
        FashionZoneDB fashionZoneDB;

        public TotaalPerMaandPerMerkDB()
        {
            fashionZoneDB = new FashionZoneDB();
            FillTotaalPerMaandPerMerkList("SELECT * From tblTotaalPerMaandPerMerk");
        }

        public ObservableCollection<TotaalPerMaandPerMerk> GetTotaalPerMaandPerMerkList()
        {
            return totaalPerMaandPerMerken;
        }

        public ObservableCollection<TotaalPerMaandPerMerk> FillTotaalPerMaandPerMerkList(string statement)
        {
            totaalPerMaandPerMerken = new ObservableCollection<TotaalPerMaandPerMerk>();

            foreach (DataRow row in fashionZoneDB.selectTable(statement).Rows)
            {
                TotaalPerMaandPerMerk totaalPerMaandPerMerk = new TotaalPerMaandPerMerk();
                totaalPerMaandPerMerk.Id = int.Parse(row[0].ToString());
                totaalPerMaandPerMerk.Maand = row[1].ToString();
                totaalPerMaandPerMerk.Jaar = int.Parse(row[2].ToString());
                totaalPerMaandPerMerk.Merk = row[3].ToString();
                totaalPerMaandPerMerk.TotBesteld = decimal.Parse(row[4].ToString());
                totaalPerMaandPerMerk.TotVoorzien = decimal.Parse(row[5].ToString());
                totaalPerMaandPerMerk.TotBetaald = decimal.Parse(row[6].ToString());
                totaalPerMaandPerMerken.Add(totaalPerMaandPerMerk);
            }

            return totaalPerMaandPerMerken;
        }

        public void AddTotaalPerMaandPerMerk(TotaalPerMaandPerMerk totaalPerMaandPerMerk)
        {
            totaalPerMaandPerMerken.Add(totaalPerMaandPerMerk);

            string stmt = "INSERT INTO tblTotaalPerMaandPerMerk (Maand, Jaar, Merk, TotBesteld, TotVoorzien, TotBetaald) " +
                "VALUES('" + totaalPerMaandPerMerk.Maand + "', " + totaalPerMaandPerMerk.Jaar + ", '" + totaalPerMaandPerMerk.Merk + "', " +
                totaalPerMaandPerMerk.TotBesteld.ToString().Replace(",", ".") + ", " + totaalPerMaandPerMerk.TotVoorzien.ToString().Replace(",", ".") + ", " +
                totaalPerMaandPerMerk.TotBetaald.ToString().Replace(",", ".") + ")";

            fashionZoneDB.updateTable(stmt);
        }

        public void UpdateTotaalPerMaandPerMerk(TotaalPerMaandPerMerk totaalPerMaandPerMerk)
        {
            int index = totaalPerMaandPerMerken.IndexOf(totaalPerMaandPerMerk);
            totaalPerMaandPerMerken[index] = totaalPerMaandPerMerk;

            string stmt = "UPDATE tblTotaalPerMaandPerMerk " +
                "SET Maand='" + totaalPerMaandPerMerk.Maand + "', Merk='" + totaalPerMaandPerMerk.Merk + "', " + totaalPerMaandPerMerk.Jaar +
                ", TotBesteld=" + totaalPerMaandPerMerk.TotBesteld.ToString().Replace(",", ".") + ", TotVoorzien=" + totaalPerMaandPerMerk.TotVoorzien.ToString().Replace(",", ".") +
                ", TotAKprijs=" + totaalPerMaandPerMerk.TotBetaald.ToString().Replace(",", ".") + " WHERE Maand=" + totaalPerMaandPerMerk.Maand + " AND Merk ='" + totaalPerMaandPerMerk.Merk + ";";

            fashionZoneDB.updateTable(stmt);
        }

        public void DeleteTotaalPerMaandPerMerk(TotaalPerMaandPerMerk totaalPerMaandPerMerk)
        {
            int index = totaalPerMaandPerMerken.IndexOf(totaalPerMaandPerMerk);
            totaalPerMaandPerMerken.RemoveAt(index);

            string stmt = "DELETE FROM tblTotaalPerMaandPerMerk " +
                "WHERE Id=" + totaalPerMaandPerMerk.Id + ";";

            fashionZoneDB.updateTable(stmt);
        }
    }
}
