using MahApps.Metro.Controls;
using System;
using System.Linq;
using System.Windows;
using FashionZoneData;

namespace FashionZone
{
    /// <summary>
    /// Interaction logic for BestellingToevoegen.xaml
    /// </summary>
    public partial class BestellingToevoegen : MetroWindow
    {
        BestellingDB bestellingDB;
        MerkDB merkDB;

        public BestellingToevoegen(BestellingDB bestellingDB)
        {
            InitializeComponent();

            this.bestellingDB = bestellingDB;
            merkDB = new MerkDB();

            merkComboBox.DisplayMemberPath = "MerkNaam";
            merkComboBox.ItemsSource = merkDB.GetMerkList();
            merkComboBox.SelectedIndex = 0;

            bestelDatePicker.SelectedDate = DateTime.Now;
            leverDatePicker.SelectedDate = DateTime.Now;

            bonNummerTextBox.Focus();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            if (bonNummerTextBox.Text.Trim() != null)
            {
                bool bestellingExists = bestellingDB.GetBestellingList().Any(item => item.BonNummer == bonNummerTextBox.Text);

                if (bestellingExists)
                {
                    MessageBox.Show("Er bestaat al een bestelling met dit BonNummer, gelieve een unieke waarde in te geven.");
                    return;
                }

                Bestelling bestelling = new Bestelling(bonNummerTextBox.Text, bestelDatePicker.SelectedDate.Value.Date.ToShortDateString(), merkComboBox.Text.ToString(), leverDatePicker.SelectedDate.Value.Date.ToShortDateString());
                bestellingDB.AddBestelling(bestelling);

                this.Close();
            }
            else
            {
                MessageBox.Show("Gelieve het bonnummer in te vullen");
                return;
            }


        }
    }
}
