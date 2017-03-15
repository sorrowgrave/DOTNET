using FashionZoneData;
using MahApps.Metro.Controls;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using CustomDocumentPaginator;
using System.Windows.Data;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Threading;

namespace FashionZone
{
    public partial class Beheer : MetroWindow
    {
        private ArtikelDB artikelDB;
        private BestellingDB bestellingDB;
        private CategorieDB categorieDB;
        private MerkDB merkDB;
        private TotaalPerJaarDB totaalPerJaarDB;
        private TotaalPerMaandDB totaalPerMaandDB;
        private TotaalPerJaarPerMerkDB totaalPerJaarPerMerkDB;
        private TotaalPerMaandPerMerkDB totaalPerMaandPerMerkDB;

        private static List<string> searchCrit = new List<string>(new string[] { "Selecteer", "Artikelnr", "Artikelnaam", "Categorie", "Merk", "Datum", "Kleur" });

        private string searchStatement = "SELECT * FROM tblGegevens WHERE ";

        private static List<Totaal> testList = new List<Totaal>();

        public Beheer()
        {
            InitializeComponent();
            InitializeSearch();

            Totaal totaal = new Totaal();
            totaal.Maand = "November";
            totaal.Jaar = "2015";
            totaal.RichtPrijs = 250.50f;
            totaal.TotaleUitgave = 285.38f;

            testList.Add(totaal);

            maandTotalenDataGrid.ItemsSource = testList;

            artikelDB = new ArtikelDB();
            bestellingDB = new BestellingDB();
            categorieDB = new CategorieDB();
            merkDB = new MerkDB();
            totaalPerJaarDB = new TotaalPerJaarDB();
            totaalPerMaandDB = new TotaalPerMaandDB();
            totaalPerJaarPerMerkDB = new TotaalPerJaarPerMerkDB();
            totaalPerMaandPerMerkDB = new TotaalPerMaandPerMerkDB();

            inventoryDataGrid.ItemsSource = artikelDB.GetArtikelsList();
            ordersDataGrid.ItemsSource = bestellingDB.GetBestellingList();

            
            TotAantalLabel.Content = inventoryDataGrid.Items.Count + " artikels gevonden.";
            TotAKprijsLabel.Content = artikelDB.TotAKPrijs.ToString("#.##");
            TotVKprijsLabel.Content = artikelDB.TotVKPrijs.ToString("#.##");
        }


        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    ArtikelToevoegen artikelToevoegen = new ArtikelToevoegen(artikelDB);
                    artikelToevoegen.Show();
                    break;
                case 1:
                    BestellingToevoegen bestellingToevoegen = new BestellingToevoegen(bestellingDB);
                    bestellingToevoegen.Show();
                    break;
            }
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    if (inventoryDataGrid.SelectedItems.Count > 0)
                    {
                        MessageBoxResult result = MessageBox.Show("Je staat op het punt om " + inventoryDataGrid.SelectedItems.Count + " rijen te verwijderen.\nWil u doorgaan?", "Rijen verwijderen",
                            MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if (result == MessageBoxResult.Yes)
                        {
                            IList<Artikel> selectedArtikels = new List<Artikel>();
                            foreach (Artikel selectedArtikel in inventoryDataGrid.SelectedItems)
                            {
                                selectedArtikels.Add(selectedArtikel);
                            }
                            foreach (Artikel selectedArtikel in selectedArtikels)
                            {
                                artikelDB.DeleteArtikel(selectedArtikel);
                            }
                        }
                    }
                    break;
                case 1:
                    if (ordersDataGrid.SelectedItems.Count > 0)
                    {
                        MessageBoxResult result = MessageBox.Show("Je staat op het punt om " + ordersDataGrid.SelectedItems.Count + " rijen te verwijderen.\nWil u doorgaan?", "Rijen verwijderen",
                                MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if (result == MessageBoxResult.Yes)
                        {
                            IList<Bestelling> selectedBestellingen = new List<Bestelling>();
                            foreach (Bestelling selectedBestelling in ordersDataGrid.SelectedItems)
                            {
                                selectedBestellingen.Add(selectedBestelling);
                            }
                            foreach (Bestelling selectedBestelling in selectedBestellingen)
                            {
                                bestellingDB.DeleteArtikel(selectedBestelling);
                            }
                        }
                    }
                    break;
            }
        }

        private void ordersDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (ordersDataGrid.SelectedItem == null) return;
            var selectedBestelling = ordersDataGrid.SelectedItem as Bestelling;

            BestellingAanpassen bestellingAanpassen = new BestellingAanpassen(selectedBestelling, bestellingDB);
            bestellingAanpassen.Show();

        }

        private void totalenDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (maandTotalenDataGrid.SelectedItem == null) return;
            var selectedTotaal = maandTotalenDataGrid.SelectedItem as Totaal;

            TotaalDetailView totaalDetailView = new TotaalDetailView(selectedTotaal.Maand, selectedTotaal.Jaar);
            totaalDetailView.Show();
        }

        public void tb_KeyDown(object sender, EventArgs e)
        {
            UserControlSearch searchSender = (UserControlSearch)sender;


            if (searchSender.searchTextBox.Text.Trim() != "")
            {
                Regex r = new Regex(searchSender.searchTextBox.Text.Replace(" ", String.Empty).ToLower());

                switch (searchSender.searchComboBox.Text)
                {
                    case "Artikelnaam":
                        inventoryDataGrid.ItemsSource = inventoryDataGrid.Items.OfType<Artikel>().Where(x => r.IsMatch(x.Artikelnaam.Replace(" ", String.Empty).ToLower()));
                        break;

                    case "Artikelnummer":
                        inventoryDataGrid.ItemsSource = inventoryDataGrid.Items.OfType<Artikel>().Where(x => r.IsMatch(x.Artikelnr.Replace(" ", String.Empty).ToLower()));
                        break;

                    case "Kleur":
                        inventoryDataGrid.ItemsSource = inventoryDataGrid.Items.OfType<Artikel>().Where(x => r.IsMatch(x.Kleur.Replace(" ", String.Empty).ToLower()));
                        break;
                }

                CalculateMetaData();

            }
            else
            {
                inventoryDataGrid.ItemsSource = artikelDB.GetArtikelsList();

            }



        }

        public void searchDropClosed(object sender, EventArgs e)
        {
            UserControlSearch userSearchSender = (UserControlSearch)sender;

            switch (userSearchSender.Name)
            {
                case "userControlSearch":
                    userControlSearch2.Visibility = Visibility.Visible;
                    break;
                case "userControlSearch2":
                    userControlSearch3.Visibility = Visibility.Visible;
                    break;


            }
        }

        public void categorieDropClosed(object sender, EventArgs e)
        {
            UserControlSearch userCategorieSender = (UserControlSearch)sender;

            if (userCategorieSender.searchComboBox.Text == "Categorie")
            {
                inventoryDataGrid.ItemsSource = inventoryDataGrid.Items.OfType<Artikel>().Where(x => x.Categorie == userCategorieSender.categoryComboBox.Text);
            }
            else
            {
                inventoryDataGrid.ItemsSource = inventoryDataGrid.Items.OfType<Artikel>().Where(x => x.Merk == userCategorieSender.categoryComboBox.Text);
            }




        }

        private void printButton_Click(object sender, RoutedEventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    PrintDialog Printdlg = new PrintDialog();
                    if ((bool)Printdlg.ShowDialog().GetValueOrDefault())
                    {
                        string documentTitle = "Inventory";

                        Size pageSize = new Size(8.27 * 96, 11.69 * 96);

                        DataGrid dupe = new DataGrid();
                        foreach (DataGridColumn dgc in inventoryDataGrid.Columns)
                        {
                            dupe.Columns.Add(new DataGridTextColumn
                            {
                                Width = dgc.Width,
                                Header = dgc.Header,
                                Binding = new Binding(string.Format("{0}", dgc.SortMemberPath)),
                                DisplayIndex = dgc.DisplayIndex
                            });
                        }
                        dupe.ItemsSource = inventoryDataGrid.ItemsSource;

                        dupe.Columns.RemoveAt(dupe.Columns.Count - 1);
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
                    break;
                case 1:
                    PrintDialog PrintDialog = new PrintDialog();
                    if ((bool)PrintDialog.ShowDialog().GetValueOrDefault())
                    {
                        string documentTitle = "Orders";

                        Size pageSize = new Size(8.27 * 96, 11.69 * 96);

                        DataGrid dupe = new DataGrid();
                        foreach (DataGridColumn dgc in ordersDataGrid.Columns)
                        {
                            dupe.Columns.Add(new DataGridTextColumn
                            {
                                Width = dgc.Width,
                                Header = dgc.Header,
                                Binding = new Binding(string.Format("{0}", dgc.SortMemberPath)),
                                DisplayIndex = dgc.DisplayIndex
                            });
                        }
                        dupe.ItemsSource = ordersDataGrid.ItemsSource;

                        CustomDataGridDocumentPaginator paginator = new CustomDataGridDocumentPaginator(dupe, documentTitle, pageSize, new Thickness(0, 20, 0, 70));
                        PrintDialog.PrintDocument(paginator, "Grid");
                    }
                    break;
            }
        }

        private void inventoryDataGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            Artikel artikelBefore = (Artikel)e.Row.Item;
            decimal AKprijsBefore = artikelBefore.AKprijs;
            decimal VKprijsBefore = artikelBefore.VKprijs;
            int aantalBefore = artikelBefore.Aantal;

            if (inventoryDataGrid.SelectedItem != null)
            {
                (sender as DataGrid).RowEditEnding -= inventoryDataGrid_RowEditEnding;
                (sender as DataGrid).CommitEdit();
                (sender as DataGrid).Items.Refresh();
                (sender as DataGrid).RowEditEnding += inventoryDataGrid_RowEditEnding;
            }

            Artikel artikel = (Artikel)e.Row.Item;
            decimal AKprijsAfter = artikel.AKprijs;
            decimal VKprijsAfter = artikel.VKprijs;
            int aantalAfter = artikel.Aantal;

            if (aantalBefore != aantalAfter)
            {
                artikel.TotAKprijs = artikel.AKprijs * artikel.Aantal;
                artikel.TotVKprijs = artikel.VKprijs * artikel.Aantal;
            }
            else
            {
                if (AKprijsBefore != AKprijsAfter)
                    artikel.TotAKprijs = artikel.AKprijs * artikel.Aantal;
                if (VKprijsBefore != VKprijsAfter)
                    artikel.TotVKprijs = artikel.VKprijs * artikel.Aantal;
            }

            artikelDB.UpdateRow(artikel);
        }

        private void settingsButton_Click(object sender, RoutedEventArgs e)
        {
            Instellingen instellingen = new Instellingen(categorieDB, merkDB);
            instellingen.Show();
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.Source is TabControl)
            {
                userControlSearch.Visibility = Visibility.Hidden;
                userControlSearch2.Visibility = Visibility.Hidden;
                userControlSearch3.Visibility = Visibility.Hidden;

                switch (tabControl.SelectedIndex)
                {
                    case 2:
                        jaarTextBox.Visibility = Visibility.Visible;
                        userControlSearch.Visibility = Visibility.Hidden;
                        resetButton.Visibility = Visibility.Hidden;
                        searchButton.Visibility = Visibility.Hidden;
                        break;

                    default:
                        resetButton.Visibility = Visibility.Visible;
                        searchButton.Visibility = Visibility.Visible;
                        jaarTextBox.Visibility = Visibility.Hidden;
                        userControlSearch.Visibility = Visibility.Visible;
                        break;
                }
            }
        }

        private void CalculateMetaData()
        {
            decimal totAKPrijs = 0;
            decimal totVKPrijs = 0;

            TotAantalLabel.Content = inventoryDataGrid.Items.Count + " artikels gevonden.";

            foreach (Artikel artikel in inventoryDataGrid.Items.OfType<Artikel>())
            {
                totAKPrijs += artikel.TotAKprijs;
                totVKPrijs += artikel.TotVKprijs;
            }

            TotAKprijsLabel.Content = totAKPrijs.ToString("#.##");
            TotVKprijsLabel.Content = totVKPrijs.ToString("#.##");


        }

        private void InitializeSearch()
        {
            foreach (UserControlSearch userControlSearch in userControlSearchCanvas.Children)
            {
                userControlSearch.EnterSearch += new EventHandler(tb_KeyDown);
                userControlSearch.SearchDropClosed += new EventHandler(searchDropClosed);
                userControlSearch.CategorieDropClosed += new EventHandler(categorieDropClosed);

                userControlSearch.searchComboBox.ItemsSource = searchCrit.Distinct();
            }
        }
        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            foreach(UserControlSearch userControlSearch in userControlSearchCanvas.Children)
            {

                userControlSearch.categoryComboBox.Visibility = Visibility.Hidden;
                userControlSearch.searchLabel.Visibility = Visibility.Hidden;
                userControlSearch.searchTextBox.Visibility = Visibility.Hidden;

                userControlSearch.searchComboBox.SelectedIndex = 0;
                userControlSearch.categoryComboBox.SelectedIndex = 0;
                userControlSearch.searchTextBox.Text = "";

            }

            inventoryDataGrid.ItemsSource = artikelDB.GetArtikelsList();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            int searchCounter = 0;

            foreach (UserControlSearch userControlSearch in userControlSearchCanvas.Children)
            { 
                if(userControlSearch.searchComboBox.SelectedIndex != 0)
                {
                    searchCounter++;

                    if (searchCounter > 1)
                        searchStatement += " AND ";

                    if(userControlSearch.categoryComboBox.Visibility == Visibility.Visible)
                    {
                        searchStatement += userControlSearch.searchComboBox.Text + "='" + userControlSearch.categoryComboBox.Text + "'";
                    }
                    else
                        searchStatement += "FashionZone.ReplaceVS(" + userControlSearch.searchComboBox.Text + ", ' ', '')" + " = " + "FashionZone.Replace('" + userControlSearch.searchTextBox.Text + "', ' ', '')";
                }
                //REPLACE(fld_or_variable, ' ', '')
            }

            MessageBox.Show(searchStatement);

            inventoryDataGrid.ItemsSource = artikelDB.FillArtikelsList(searchStatement);
            CalculateMetaData();

            searchStatement = "SELECT * FROM tblGegevens WHERE ";
        }

        private void jaarTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if(jaarTextBox.Text.Trim() != "" )
            {
                jaarTextBox.Text = "Jaar";
	    }
	}

        private async Task<string> GenerateYear()
        {
            string[] maandNamen = new string[] { "Januari", "Februari", "Maart", "April", "Mei", "Juni", "Juli", "Augustus", "September", "Oktober", "November", "December" };
            System.Collections.ObjectModel.ObservableCollection<Merk> merken = merkDB.GetMerkList();
            this.Cursor = Cursors.Wait;
            
            var generateYearTask = Task.Run(() =>
            {
                try
                {
                    string[] totalenRowHeaders = new string[] { "Totaal Excl BTW", "Totaal Incl BTW", "Omzet per jaar", "Omzet per maand", "Omzet per dag" };

                    for (int i = 0; i < totalenRowHeaders.Length; i++)
                    {
                        TotaalPerJaar totaalPerJaar = new TotaalPerJaar();
                        totaalPerJaar.Jaar = int.Parse(jaarTextBox.Text);
                        totaalPerJaar.Soort = totalenRowHeaders[i];
                        MessageBox.Show(totaalPerJaar.Soort);
                        totaalPerJaarDB.AddTotaalPerJaar(totaalPerJaar);
                    }
                    return "Operation Succeeded";
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return "Operation Failed";
                }
            });

            await Dispatcher.InvokeAsync(() =>
            {
                try
                {
                    for (int i = 0; i < maandNamen.Length; i++)
                    {
                        TotaalPerMaand totaalPerMaand = new TotaalPerMaand();
                        totaalPerMaand.Jaar = int.Parse(jaarTextBox.Text);
                        totaalPerMaand.Maand = maandNamen[i];
                        totaalPerMaandDB.AddTotaalPerMaand(totaalPerMaand);
                    }
                    return "Operation Succeeded";
                }
                catch (Exception)
                {
                    return "Operation Failed";
                }
            });

            await Dispatcher.InvokeAsync(() =>
            {
                try
                {
                    foreach (Merk merk in merken)
                    {
                        TotaalPerJaarPerMerk totaalPerJaarPerMerk = new TotaalPerJaarPerMerk();
                        totaalPerJaarPerMerk.Jaar = int.Parse(jaarTextBox.Text);
                        totaalPerJaarPerMerk.Merk = merk.MerkNaam;
                        totaalPerJaarPerMerkDB.AddTotaalPerJaarPerMerk(totaalPerJaarPerMerk);
                    }
                    return "Operation Succeeded";
                }
                catch (Exception)
                {
                    return "Operation Failed";
                }
            });

            await Dispatcher.InvokeAsync(() =>
            {
                try
                {
                    for (int i = 0; i < maandNamen.Length; i++)
                    {
                        foreach (Merk merk in merken)
                        {
                            TotaalPerMaandPerMerk totaalPerMaandPerMerk = new TotaalPerMaandPerMerk();
                            totaalPerMaandPerMerk.Jaar = int.Parse(jaarTextBox.Text);
                            totaalPerMaandPerMerk.Maand = maandNamen[i];
                            totaalPerMaandPerMerk.Merk = merk.MerkNaam;
                            totaalPerMaandPerMerkDB.AddTotaalPerMaandPerMerk(totaalPerMaandPerMerk);
                        }
                    }
                    return "Operation Succeeded";
                }
                catch (Exception)
                {
                    return "Operation Failed";
                }
            });


            //Task.WaitAll(generateYearTask, generateMonthTask, generateBrandPerYearTask, generateBrandPerMonthTask);
            await Task.WhenAll(generateYearTask);
            this.Cursor = null;
            return "Task Executed";
        }

        private async void jaarTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                bool jaarExists = totaalPerJaarDB.GetTotaalPerJaarList().Any(x => x.Jaar == int.Parse(jaarTextBox.Text));

                if (!jaarExists)
                {
                    MessageBoxResult resultBox = MessageBox.Show("Je staat op het punt om totalen te genereren voor het jaar " + jaarTextBox.Text + ".\nWil u doorgaan?", "Totaal pagina genereren",
                            MessageBoxButton.YesNo, MessageBoxImage.Question);
                    string result = await GenerateYear();
                }
            }
        }
    }
}
