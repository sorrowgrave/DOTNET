using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionZoneData
{
    public class TotaalPerJaarPerMerkDB
    {
        private ObservableCollection<TotaalPerJaarPerMerk> totaalPerJaarPerMerken;
        FashionZoneDB fashionZoneDB;

        public TotaalPerJaarPerMerkDB()
        {
            fashionZoneDB = new FashionZoneDB();
            FillTotaalPerJaarPerMerkList("SELECT * From tblTotaalPerJaarPerMerk");
        }

        public ObservableCollection<TotaalPerJaarPerMerk> GetTotaalPerJaarPerMerkList()
        {
            return totaalPerJaarPerMerken;
        }

        public ObservableCollection<TotaalPerJaarPerMerk> FillTotaalPerJaarPerMerkList(string statement)
        {
            totaalPerJaarPerMerken = new ObservableCollection<TotaalPerJaarPerMerk>();

            foreach (DataRow row in fashionZoneDB.selectTable(statement).Rows)
            {
                TotaalPerJaarPerMerk totaalPerJaarPerMerk = new TotaalPerJaarPerMerk();
                totaalPerJaarPerMerk.Jaar = int.Parse(row[0].ToString());
                totaalPerJaarPerMerk.Merk = row[1].ToString();
                totaalPerJaarPerMerk.TotBesteld = decimal.Parse(row[2].ToString());
                totaalPerJaarPerMerk.TotVoorzien = decimal.Parse(row[3].ToString());
                totaalPerJaarPerMerk.TotBetaald = decimal.Parse(row[4].ToString());
                totaalPerJaarPerMerken.Add(totaalPerJaarPerMerk);
            }

            return totaalPerJaarPerMerken;
        }

        public void AddTotaalPerJaarPerMerk(TotaalPerJaarPerMerk totaalPerJaarPerMerk)
        {
            totaalPerJaarPerMerken.Add(totaalPerJaarPerMerk);

            string stmt = "INSERT INTO tblTotaalPerJaarPerMerk (Jaar, Merk, TotBesteld, TotVoorzien, TotBetaald) " +
                "VALUES(" + totaalPerJaarPerMerk.Jaar + ", '" + totaalPerJaarPerMerk.Merk + "', " +
                totaalPerJaarPerMerk.TotBesteld.ToString().Replace(",", ".") + ", " + totaalPerJaarPerMerk.TotVoorzien.ToString().Replace(",", ".") + ", " +
                totaalPerJaarPerMerk.TotBetaald.ToString().Replace(",", ".") + ")";

            fashionZoneDB.updateTable(stmt);
        }

        public void UpdateTotaalPerJaarPerMerk(TotaalPerJaarPerMerk totaalPerJaarPerMerk)
        {
            int index = totaalPerJaarPerMerken.IndexOf(totaalPerJaarPerMerk);
            totaalPerJaarPerMerken[index] = totaalPerJaarPerMerk;

            string stmt = "UPDATE tblTotaalPerJaarPerMerk " +
                "SET Jaar=" + totaalPerJaarPerMerk.Jaar + ", Merk='" + totaalPerJaarPerMerk.Merk +
                "', TotBesteld=" + totaalPerJaarPerMerk.TotBesteld.ToString().Replace(",", ".") + ", TotVoorzien=" + totaalPerJaarPerMerk.TotVoorzien.ToString().Replace(",", ".") +
                ", TotAKprijs=" + totaalPerJaarPerMerk.TotBetaald.ToString().Replace(",", ".") + " WHERE Jaar=" + totaalPerJaarPerMerk.Jaar + " AND Merk ='" + totaalPerJaarPerMerk.Merk + ";";

            fashionZoneDB.updateTable(stmt);
        }

        public void DeleteTotaalPerJaarPerMerk(TotaalPerJaarPerMerk totaalPerJaarPerMerk)
        {
            int index = totaalPerJaarPerMerken.IndexOf(totaalPerJaarPerMerk);
            totaalPerJaarPerMerken.RemoveAt(index);

            string stmt = "DELETE FROM tblTotaalPerJaarPerMerk " +
                "WHERE Jaar=" + totaalPerJaarPerMerk.Jaar + " AND Merk ='" + totaalPerJaarPerMerk.Merk + ";";

            fashionZoneDB.updateTable(stmt);
        }
    }
}
