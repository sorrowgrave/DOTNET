using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionZoneData
{
    public class TotaalPerJaarDB
    {
        private ObservableCollection<TotaalPerJaar> totaalPerJaren;
        FashionZoneDB fashionZoneDB;

        public TotaalPerJaarDB()
        {
            fashionZoneDB = new FashionZoneDB();
            FillTotaalPerJaarList("SELECT * From tblTotaalPerJaar");
        }

        public ObservableCollection<TotaalPerJaar> GetTotaalPerJaarList()
        {
            return totaalPerJaren;
        }

        public ObservableCollection<TotaalPerJaar> FillTotaalPerJaarList(string statement)
        {
            totaalPerJaren = new ObservableCollection<TotaalPerJaar>();

            foreach (DataRow row in fashionZoneDB.selectTable(statement).Rows)
            {
                TotaalPerJaar totaalPerJaar = new TotaalPerJaar();
                totaalPerJaar.Jaar = int.Parse(row[0].ToString());
                totaalPerJaar.Soort = row[1].ToString();
                totaalPerJaar.TotBesteld = decimal.Parse(row[2].ToString());
                totaalPerJaar.TotVoorzien = decimal.Parse(row[3].ToString());
                totaalPerJaar.TotBetaald = decimal.Parse(row[4].ToString());
                totaalPerJaren.Add(totaalPerJaar);
            }
            return totaalPerJaren;
        }

        public void AddTotaalPerJaar(TotaalPerJaar totaalPerJaar)
        {
            totaalPerJaren.Add(totaalPerJaar);

            string stmt = "INSERT INTO tblTotaalPerJaar (Jaar, Soort, TotBesteld, TotVoorzien, TotBetaald) " +
                "VALUES(" + totaalPerJaar.Jaar + ", '" + totaalPerJaar.Soort + "', " +
                totaalPerJaar.TotBesteld.ToString().Replace(",", ".") + ", " + totaalPerJaar.TotVoorzien.ToString().Replace(",", ".") + ", " + 
                totaalPerJaar.TotBetaald.ToString().Replace(",", ".") + ")";

            fashionZoneDB.updateTable(stmt);
        }

        public void UpdateTotaalPerJaar(TotaalPerJaar totaalPerJaar)
        {
            int index = totaalPerJaren.IndexOf(totaalPerJaar);
            totaalPerJaren[index] = totaalPerJaar;

            string stmt = "UPDATE tblTotaalPerJaar " +
                "SET Jaar=" + totaalPerJaar.Jaar + ", Soort='" + totaalPerJaar.Soort + 
                "', TotBesteld=" + totaalPerJaar.TotBesteld.ToString().Replace(",", ".") + ", TotVoorzien=" + totaalPerJaar.TotVoorzien.ToString().Replace(",", ".") +
                ", TotAKprijs=" + totaalPerJaar.TotBetaald.ToString().Replace(",", ".") + " WHERE Jaar=" + totaalPerJaar.Jaar + " AND Soort='"+ totaalPerJaar.Soort + "';";

            fashionZoneDB.updateTable(stmt);
        }

        public void DeleteTotaalPerJaar(TotaalPerJaar totaalPerJaar)
        {
            int index = totaalPerJaren.IndexOf(totaalPerJaar);
            totaalPerJaren.RemoveAt(index);

            string stmt = "DELETE FROM tblTotaalPerJaar " +
                "WHERE Jaar=" + totaalPerJaar.Jaar + " AND Soort='" + totaalPerJaar.Soort + "';";

            fashionZoneDB.updateTable(stmt);
        }
    }
}
