using FashionZoneData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FashionZone
{
    /// <summary>
    /// Interaction logic for UserControlSearch.xaml
    /// </summary>
    public partial class UserControlSearch : UserControl
    {
        public event EventHandler EnterSearch;
        public event EventHandler SearchDropClosed;
        public event EventHandler CategorieDropClosed;

        private CategorieDB categorieDB;
        private MerkDB merkDB;


        public UserControlSearch()
        {
            InitializeComponent();
            searchTextBox.KeyDown += new KeyEventHandler(tb_KeyDown);
           

            categorieDB = new CategorieDB();
            merkDB = new MerkDB();
        }


        private void searchComboBox_DropDownClosed(object sender, EventArgs e)
        {
            hideElements();
            searchLabel.Content = searchComboBox.SelectedValue.ToString();

            switch (searchComboBox.SelectedValue.ToString().ToLower())
            {  
                case "artikelnaam":
                case "artikelnr":
                case "productcode":
                case "kleur":
                    searchLabel.Visibility = Visibility.Visible;
                    searchTextBox.Visibility = Visibility.Visible;
                    searchTextBox.Focus();
                    break;

                case "categorie":
                    categoryComboBox.DisplayMemberPath = "CategorieNaam";
                    categoryComboBox.ItemsSource = categorieDB.GetCategorieList();
                    searchLabel.Visibility = Visibility.Visible;
                    categoryComboBox.Visibility = Visibility.Visible;
                    break;
                case "merk":
                    categoryComboBox.DisplayMemberPath = "MerkNaam";
                    categoryComboBox.ItemsSource = merkDB.GetMerkList();
                    searchLabel.Visibility = Visibility.Visible;
                    categoryComboBox.Visibility = Visibility.Visible;
                    break;

                case "datum":
                    vanLabel.Visibility = Visibility.Visible;
                    totLabel.Visibility = Visibility.Visible;
                    searchLabel.Visibility = Visibility.Visible;
                    beginDatePicker.Visibility = Visibility.Visible;
                    endDatePicker.Visibility = Visibility.Visible;
                    break;


            }

            if (SearchDropClosed != null)
            {
                SearchDropClosed(this, new EventArgs());
            }


        }

        public void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if(EnterSearch != null)
                {
                    EnterSearch(this, new EventArgs());
                }
            }
        }

        private void categoryComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (CategorieDropClosed != null)
            {
                CategorieDropClosed(this, new EventArgs());
            }
        }



        public void hideElements()
        {
            searchLabel.Visibility = Visibility.Hidden;
            searchTextBox.Visibility = Visibility.Hidden;
            categoryComboBox.Visibility = Visibility.Hidden;
            endDatePicker.Visibility = Visibility.Hidden;
            beginDatePicker.Visibility = Visibility.Hidden;
            vanLabel.Visibility = Visibility.Hidden;
            totLabel.Visibility = Visibility.Hidden;
        }
    }
}
