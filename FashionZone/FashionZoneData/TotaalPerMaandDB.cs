using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionZoneData
{
    public class TotaalPerMaandDB
    {
        private ObservableCollection<TotaalPerMaand> totaalPerMaanden;
        FashionZoneDB fashionZoneDB;

        public TotaalPerMaandDB()
        {
            fashionZoneDB = new FashionZoneDB();
            FillTotaalPerMaandList("SELECT * From tblTotaalPerMaand");
        }

        public ObservableCollection<TotaalPerMaand> GetTotaalPerMaandList()
        {
            return totaalPerMaanden;
        }

        public ObservableCollection<TotaalPerMaand> FillTotaalPerMaandList(string statement)
        {
            totaalPerMaanden = new ObservableCollection<TotaalPerMaand>();

            foreach (DataRow row in fashionZoneDB.selectTable(statement).Rows)
            {
                TotaalPerMaand totaalPerMaand = new TotaalPerMaand();
                totaalPerMaand.Id = int.Parse(row[0].ToString());
                totaalPerMaand.Maand = row[1].ToString();
                totaalPerMaand.Jaar = int.Parse(row[2].ToString());
                totaalPerMaand.TotBesteld = decimal.Parse(row[3].ToString());
                totaalPerMaand.TotVoorzien = decimal.Parse(row[4].ToString());
                totaalPerMaand.TotBetaald = decimal.Parse(row[5].ToString());
                totaalPerMaanden.Add(totaalPerMaand);
            }

            return totaalPerMaanden;
        }

        public void AddTotaalPerMaand(TotaalPerMaand totaalPerMaand)
        {
            totaalPerMaanden.Add(totaalPerMaand);

            string stmt = "INSERT INTO tblTotaalPerMaand (Jaar, Maand, TotBesteld, TotVoorzien, TotBetaald) " +
                "VALUES(" + totaalPerMaand.Jaar + ", '" + totaalPerMaand.Maand + "', " +
                totaalPerMaand.TotBesteld.ToString().Replace(",", ".") + ", " + totaalPerMaand.TotVoorzien.ToString().Replace(",", ".") + ", " +
                totaalPerMaand.TotBetaald.ToString().Replace(",", ".") + ")";

            fashionZoneDB.updateTable(stmt);
        }

        public void UpdateTotaalPerMaand(TotaalPerMaand totaalPerMaand)
        {
            int index = totaalPerMaanden.IndexOf(totaalPerMaand);
            totaalPerMaanden[index] = totaalPerMaand;

            string stmt = "UPDATE tblTotaalPerMaand " +
                "SET Jaar=" + totaalPerMaand.Jaar + ", Maand='" + totaalPerMaand.Maand +
                "', TotBesteld=" + totaalPerMaand.TotBesteld.ToString().Replace(",", ".") + ", TotVoorzien=" + totaalPerMaand.TotVoorzien.ToString().Replace(",", ".") +
                ", TotAKprijs=" + totaalPerMaand.TotBetaald.ToString().Replace(",", ".") + " WHERE Id=" + totaalPerMaand.Id + ";";

            fashionZoneDB.updateTable(stmt);
        }

        public void DeleteTotaalPerMaand(TotaalPerMaand totaalPerMaand)
        {
            int index = totaalPerMaanden.IndexOf(totaalPerMaand);
            totaalPerMaanden.RemoveAt(index);

            string stmt = "DELETE FROM tblTotaalPerMaand " +
                "WHERE Id=" + totaalPerMaand.Id + ";";

            fashionZoneDB.updateTable(stmt);
        }
    }
}
