using FashionZoneData;
using MahApps.Metro.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using CustomDocumentPaginator;

namespace FashionZone
{
    /// <summary>
    /// Interaction logic for BestellingAanpassen.xaml
    /// </summary>
    public partial class BestellingAanpassen : MetroWindow
    {
        BestellingDB bestellingDB;
        ArtikelDB artikelDB;
        MerkDB merkDB;
        Bestelling bestelling;

        public BestellingAanpassen(Bestelling bestelling, BestellingDB bestellingDB)
        {
            InitializeComponent();

            artikelDB = new ArtikelDB();
            this.bestellingDB = bestellingDB;
            merkDB = new MerkDB();

            DateTime dateTime = DateTime.Now;
            bestelDatePicker.SelectedDate = dateTime;

            this.bestelling = bestelling;
            this.Title = "Bestelling: " + bestelling.BonNummer;

            bonNummerTextBox.Text = bestelling.BonNummer;

            merkComboBox.DisplayMemberPath = "MerkNaam";
            merkComboBox.ItemsSource = merkDB.GetMerkList();
            merkComboBox.Text = bestelling.Merk;

            List<Artikel> filteredArtikels = artikelDB.GetArtikelsList().Where(x => x.Bonnr == bestelling.BonNummer).ToList<Artikel>();
            artikelsDataGrid.ItemsSource = filteredArtikels;
            
            bestelDatePicker.SelectedDate = DateTime.Parse(bestelling.BestelDatum);
            leverDatePicker.SelectedDate = DateTime.Parse(bestelling.LeverDatum);

            aantalLabel.Content = artikelsDataGrid.Items.Count + " artikels gevonden.";
            totAKPrijs.Content = bestelling.TotAKPrijs;
            totVKPrijs.Content = bestelling.TotVKPrijs;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            ArtikelToevoegen artikelToevoegen = new ArtikelToevoegen(artikelDB, bestelling, bestellingDB);
            artikelToevoegen.Closed += ArtikelToevoegenClosed;
            artikelToevoegen.Show();
        }

        private void ArtikelToevoegenClosed(object sender, EventArgs e)
        {
            ((Window)sender).Closed -= ArtikelToevoegenClosed;

            List<Artikel> filteredArtikels = artikelDB.GetArtikelsList().Where(x => x.Bonnr == bestelling.BonNummer).ToList<Artikel>();
            artikelsDataGrid.ItemsSource = filteredArtikels;

            if(filteredArtikels.Count() > 0)
            {
                bestelling.TotAKPrijs += filteredArtikels.Last().TotAKprijs;
                bestelling.TotVKPrijs += filteredArtikels.Last().TotVKprijs;
                bestellingDB.UpdatePrijs(bestelling);

                aantalLabel.Content = artikelsDataGrid.Items.Count + " artikels gevonden.";
                totAKPrijs.Content = bestelling.TotAKPrijs;
                totVKPrijs.Content = bestelling.TotVKPrijs;
            }
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void printButton_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog Printdlg = new PrintDialog();
            if ((bool)Printdlg.ShowDialog().GetValueOrDefault())
            {
                string documentTitle = "Inventory";
                //Size pageSize = new Size(Printdlg.PrintableAreaWidth, Printdlg.PrintableAreaHeight);
                Size pageSize = new Size(8.27 * 96, 11.69 * 96);

                DataGrid dupe = new DataGrid();
                foreach (DataGridColumn dgc in artikelsDataGrid.Columns)
                {
                    dupe.Columns.Add(new DataGridTextColumn
                    {
                        Width = dgc.Width,
                        Header = dgc.Header,
                        Binding = new Binding(string.Format("{0}", dgc.SortMemberPath)),
                        DisplayIndex = dgc.DisplayIndex
                    });
                }
                dupe.ItemsSource = artikelsDataGrid.ItemsSource;
                
                dupe.Columns[0].Width = 60;
                dupe.Columns[2].Width = 60;
                dupe.Columns[3].Width = 60;
                dupe.Columns[5].Width = 35;
                dupe.Columns[6].Width = 35;
                dupe.Columns[7].Width = 50;
                dupe.Columns[8].Width = 35;
                dupe.Columns[9].Width = 50;
                dupe.Columns[10].Width = 35;

                CustomDataGridDocumentPaginator paginator = new CustomDataGridDocumentPaginator(dupe, documentTitle, pageSize, new Thickness(0, 20, 0, 70));
                Printdlg.PrintDocument(paginator, "Grid");
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            //BonNummer aanpassen
            if(bonNummerTextBox.Text.Trim() != null && leverDatePicker.Text.Trim() != null && bestelDatePicker.Text.Trim() != null )
            {
                bool bestellingExists = bestellingDB.GetBestellingList().Any(item => item.BonNummer == bonNummerTextBox.Text);

                if (bestellingExists)
                {
                    MessageBox.Show("Een bestelling met dit BonNummer bestaat al, gelieve een unieke waarde in te geven");
                }
                else
                {
                    if(bonNummerTextBox.Text != bestelling.BonNummer)
                    {
                        MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("U heeft het BonNummer aangepast, wilt u het BonNummer wijzigen van de bestelling en al de artikels?", "BonNummer aanpassen?", System.Windows.MessageBoxButton.YesNo);
                        if (messageBoxResult == MessageBoxResult.Yes)
                        {
                            //BonNummer bestelling aanpassen en al de artikels
                            bestelling.BonNummer = bonNummerTextBox.Text;

                            IList<Artikel> artikels = new List<Artikel>();
                            foreach (Artikel selectedArtikel in artikelsDataGrid.Items)
                            {
                                artikels.Add(selectedArtikel);
                            }
                            foreach (Artikel artikel in artikels)
                            {
                                artikel.Bonnr = bestelling.BonNummer;
                                artikelDB.UpdateRow(artikel);
                            }
                            bestellingDB.UpdateRow(bestelling);
                        }
                        else
                        {
                            MessageBox.Show("Wijziging geannuleerd");
                            bonNummerTextBox.Text = bestelling.BonNummer;
                        }
                    }
                }

                //merk aanpassen
                if (!merkComboBox.Text.Equals(bestelling.Merk))
                {
                    MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("U heeft het Merk aangepast, wilt u het Merk wijzigen van de bestelling en al de artikels?", "Merk aanpassen?", System.Windows.MessageBoxButton.YesNo);
                    if (messageBoxResult == MessageBoxResult.Yes)
                    {
                        //Merk bestelling aanpassen en al de artikels
                        bestelling.Merk = merkComboBox.Text;

                        IList<Artikel> artikels = new List<Artikel>();
                        foreach (Artikel selectedArtikel in artikelsDataGrid.Items)
                        {
                            artikels.Add(selectedArtikel);
                        }
                        foreach (Artikel artikel in artikels)
                        {
                            artikel.Merk = bestelling.Merk;
                            artikelDB.UpdateRow(artikel);
                        }
                        bestellingDB.UpdateRow(bestelling);
                    }
                    else
                    {
                        MessageBox.Show("Wijziging geannuleerd");
                        merkComboBox.Text = bestelling.Merk;
                    }
                }
            }
            else
            {
                MessageBox.Show("Gelieve alle velden in te vullen :)");
                return;
            }
        }

        private void artikelsDataGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            Artikel artikelBefore = (Artikel)e.Row.Item;
            decimal AKprijsBefore = artikelBefore.AKprijs;
            decimal VKprijsBefore = artikelBefore.VKprijs;
            int aantalBefore = artikelBefore.Aantal;

            if (artikelsDataGrid.SelectedItem != null)
            {
                (sender as DataGrid).RowEditEnding -= artikelsDataGrid_RowEditEnding;
                (sender as DataGrid).CommitEdit();
                (sender as DataGrid).Items.Refresh();
                (sender as DataGrid).RowEditEnding += artikelsDataGrid_RowEditEnding;
            }

            Artikel artikel = (Artikel)e.Row.Item;
            decimal AKprijsAfter = artikel.AKprijs;
            decimal VKprijsAfter = artikel.VKprijs;
            int aantalAfter = artikel.Aantal;

            if (aantalBefore != aantalAfter)
            {
                artikel.TotAKprijs = artikel.AKprijs * artikel.Aantal;
                artikel.TotVKprijs = artikel.VKprijs * artikel.Aantal;
                bestelling.TotAKPrijs -= AKprijsBefore;
                bestelling.TotAKPrijs += AKprijsAfter;
                bestelling.TotVKPrijs -= VKprijsBefore;
                bestelling.TotVKPrijs += VKprijsAfter;
                bestellingDB.UpdatePrijs(bestelling);
            }
            else
            {
                if (AKprijsBefore != AKprijsAfter)
                { 
                    artikel.TotAKprijs = artikel.AKprijs * artikel.Aantal;
                    bestelling.TotAKPrijs -= AKprijsBefore;
                    bestelling.TotAKPrijs += AKprijsAfter;
                    bestellingDB.UpdatePrijs(bestelling);
                }
                if (VKprijsBefore != VKprijsAfter)
                {
                    artikel.TotVKprijs = artikel.VKprijs * artikel.Aantal;
                    bestelling.TotVKPrijs -= VKprijsBefore;
                    bestelling.TotVKPrijs += VKprijsAfter;
                    bestellingDB.UpdatePrijs(bestelling);
                }
            }
            artikelDB.UpdateRow(artikel);
        }

        void OnChecked(object sender, RoutedEventArgs e)
        {
            //Artikel artikel = (Artikel)sender;
        }
    }
}
