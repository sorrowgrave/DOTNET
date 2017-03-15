using FashionZoneData;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FashionZone
{
    /// <summary>
    /// Interaction logic for Instellingen.xaml
    /// </summary>
    public partial class Instellingen : MetroWindow
    {
        CategorieDB categorieDB;
        MerkDB merkDB;
        public Instellingen(CategorieDB categorieDB, MerkDB merkDB)
        {
            InitializeComponent();

            this.categorieDB = categorieDB;
            this.merkDB = merkDB;

            categorieDataGrid.AutoGenerateColumns = false;
            merkDataGrid.AutoGenerateColumns = false;

            categorieDataGrid.ItemsSource = categorieDB.GetCategorieList();
            merkDataGrid.ItemsSource = merkDB.GetMerkList();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void merkRemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (merkDataGrid.SelectedItems.Count > 0)
            {
                MessageBoxResult result = MessageBox.Show("Je staat op het punt om " + merkDataGrid.SelectedItems.Count + " rijen te verwijderen.\nWil u doorgaan?", "Rijen verwijderen",
                                   MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    IList<Merk> selectedMerken = new List<Merk>();
                    foreach (Merk selectedMerk in merkDataGrid.SelectedItems)
                    {
                        selectedMerken.Add(selectedMerk);
                    }
                    foreach (Merk selectedMerk in selectedMerken)
                    {
                        merkDB.DeleteMerk(selectedMerk);
                    }
                }
            }
        }

        private void merkAddButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new AddInstellingenDialog("Geef een nieuwe merknaam:");
            if (dialog.ShowDialog() == true)
            {
                Merk merk = new Merk(dialog.ResponseText);
                merkDB.AddMerk(merk);
                MessageBox.Show("Merk: " + merk.MerkNaam + " toegevoegd.");
            }
        }

        private void CategorieRemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (categorieDataGrid.SelectedItems.Count > 0)
            {
                MessageBoxResult result = MessageBox.Show("Je staat op het punt om " + categorieDataGrid.SelectedItems.Count + " rijen te verwijderen.\nWil u doorgaan?", "Rijen verwijderen",
                                   MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    IList<Categorie> selectedCategories = new List<Categorie>();
                    foreach (Categorie selectedCategorie in categorieDataGrid.SelectedItems)
                    {
                        selectedCategories.Add(selectedCategorie);
                    }
                    foreach (Categorie selectedCategorie in selectedCategories)
                    {
                        categorieDB.DeleteCategorie(selectedCategorie);
                    }
                }
            }
        }

        private void categorieAddButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new AddInstellingenDialog("Geef een nieuwe categorienaam:");
            if (dialog.ShowDialog() == true)
            {
                Categorie categorie = new Categorie(dialog.ResponseText);
                categorieDB.AddCategorie(categorie);
                MessageBox.Show("Categorie: " + categorie.CategorieNaam + " toegevoegd.");
            }
        }
    }
}
