using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionZoneData
{
    public class MerkDB
    {

            private static ObservableCollection<Merk> merken;
            FashionZoneDB fashionZoneDB;

            public MerkDB()
            {
                merken = new ObservableCollection<Merk>();
                fashionZoneDB = new FashionZoneDB();
                FillMerkList("SELECT * From tblMerk");
            }

            public void AddMerk(Merk merk)
            {
                merken.Add(merk);

                string stmt = "INSERT INTO tblMerk (Merk) " +
                    "VALUES('" + merk.MerkNaam + "')";

                fashionZoneDB.updateTable(stmt);
            }

            public void FillMerkList(string stmt)
            {
                foreach (DataRow row in fashionZoneDB.selectTable(stmt).Rows)
                {
                    Merk merk = new Merk();
                    merk.Id = int.Parse(row[0].ToString());
                    merk.MerkNaam = row[1].ToString();
                    merken.Add(merk);
                }
            }

            public ObservableCollection<Merk> GetMerkList()
            {
                return merken;
            }

            public void UpdateRow(Merk merk)
            {
                int index = merken.IndexOf(merk);
                merken[index] = merk;

                string stmt = "UPDATE tblMerk " +
                    "SET Merk='" + merk.MerkNaam + ";";

                fashionZoneDB.updateTable(stmt);
            }

        public void DeleteMerk(Merk merk)
        {
            int index = merken.IndexOf(merk);
            merken.RemoveAt(index);

            string stmt = "DELETE FROM tblMerk " +
                "WHERE Id=" + merk.Id + ";";

            fashionZoneDB.updateTable(stmt);
        }
    }
}
