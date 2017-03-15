using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionZoneData
{
    public class CategorieDB
    {
        private static ObservableCollection<Categorie> categories;
        FashionZoneDB fashionZoneDB;

        public CategorieDB()
        {
            categories = new ObservableCollection<Categorie>();
            fashionZoneDB = new FashionZoneDB();
            FillCategorieList("SELECT * From tblCategorie");
        }

        public void AddCategorie(Categorie categorie)
        {
            categories.Add(categorie);

            string stmt = "INSERT INTO tblCategorie (Categorie) " +
                "VALUES('" + categorie.CategorieNaam + "')";

            fashionZoneDB.updateTable(stmt);
        }

        public void FillCategorieList(string stmt)
        {
            foreach (DataRow row in fashionZoneDB.selectTable(stmt).Rows)
            {
                Categorie categorie = new Categorie();
                categorie.Id = int.Parse(row[0].ToString());
                categorie.CategorieNaam = row[1].ToString();
                categories.Add(categorie);
            }
        }

        public ObservableCollection<Categorie> GetCategorieList()
        {
            return categories;
        }

        public void UpdateRow(Categorie categorie)
        {
            int index = categories.IndexOf(categorie);
            categories[index] = categorie;

            string stmt = "UPDATE tblCategorie " +
                "SET Categorie='" + categorie.CategorieNaam + ";";

            fashionZoneDB.updateTable(stmt);
        }
        public void DeleteCategorie(Categorie categorie)
        {
            int index = categories.IndexOf(categorie);
            categories.RemoveAt(index);

            string stmt = "DELETE FROM tblCategorie " +
                "WHERE Id=" + categorie.Id + ";";

            fashionZoneDB.updateTable(stmt);
        }
    }
}
