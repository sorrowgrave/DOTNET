using MahApps.Metro.Controls;
using System;
using System.Windows;
using FashionZoneData;

namespace FashionZone
{
    /// <summary>
    /// Interaction logic for Toevoegen.xaml
    /// </summary>
    public partial class ArtikelToevoegen : MetroWindow
    {
        private ArtikelDB artikelDB;
        private CategorieDB categorieDB;
        private MerkDB merkDB;
        private BestellingDB bestellingDB;

        public ArtikelToevoegen(ArtikelDB artikelDB)
        {
            Initialize(artikelDB);
        }

        public ArtikelToevoegen(ArtikelDB artikelDB, Bestelling bestelling, BestellingDB bestellingDB) 
        {
            Initialize(artikelDB);
            this.bestellingDB = bestellingDB;
            bonNummerTextBox.Text = bestelling.BonNummer;
            bonNummerTextBox.IsEnabled = false;
            merkComboBox.Text = bestelling.Merk;
            merkComboBox.IsEnabled = false;
        }

        public void Initialize(ArtikelDB artikelDB)
        {
            InitializeComponent();

            this.artikelDB = artikelDB;
            categorieDB = new CategorieDB();
            merkDB = new MerkDB();

            datePicker.SelectedDate = DateTime.Now;

            merkComboBox.DisplayMemberPath = "MerkNaam";
            merkComboBox.ItemsSource = merkDB.GetMerkList();

            categorieComboBox.DisplayMemberPath = "CategorieNaam";
            categorieComboBox.ItemsSource = categorieDB.GetCategorieList();

            artikelNummerTextBox.Focus();
        }
        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            artikelNummerTextBox.Clear();
            artikelNaamTextBox.Clear();
            kleurTextBox.Clear();
            aantalTextBox.Clear();
            aankoopPrijsTextBox.Clear();
            verkoopPrijsTextBox.Clear();
            bonNummerTextBox.Clear();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            if(artikelNummerTextBox.Text.Trim() != null &&
               artikelNaamTextBox.Text.Trim() != null &&
               kleurTextBox.Text.Trim() != null &&
               aantalTextBox.Text.Trim() != null &&
               aankoopPrijsTextBox.Text.Trim() != null &&
               verkoopPrijsTextBox.Text.Trim() != null &&
               bonNummerTextBox.Text.Trim() != null)
            {
                Artikel artikel = new Artikel();
                artikel.Artikelnr = artikelNummerTextBox.Text;
                artikel.Artikelnaam = artikelNaamTextBox.Text;
                artikel.Categorie = categorieComboBox.Text;
                artikel.Merk = merkComboBox.Text;
                artikel.Kleur = kleurTextBox.Text;
                artikel.Aantal = byte.Parse(aantalTextBox.Text);
                artikel.AKprijs = decimal.Parse(aankoopPrijsTextBox.Text.Replace(".", ","));
                artikel.VKprijs = decimal.Parse(verkoopPrijsTextBox.Text.Replace(".", ","));
                artikel.Datum = datePicker.SelectedDate.Value.Date.ToShortDateString();
                artikel.Bonnr = bonNummerTextBox.Text;
                artikel.TotAKprijs = artikel.Aantal * artikel.AKprijs;
                artikel.TotVKprijs = artikel.Aantal * artikel.VKprijs;
                artikelDB.AddArtikel(artikel);
            }
            else
            {
                MessageBox.Show("Gelieve al de velden in te vullen");
                return;
            }

        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
