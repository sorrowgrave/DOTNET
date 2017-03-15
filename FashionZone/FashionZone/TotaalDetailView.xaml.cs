using MahApps.Metro.Controls;
using System.Windows;

namespace FashionZone
{
    /// <summary>
    /// Interaction logic for TotaalDetailView.xaml
    /// </summary>
    public partial class TotaalDetailView : MetroWindow
    {
        public TotaalDetailView(string maand, string jaar)
        {
            InitializeComponent();
            this.Title = "Overzicht " + maand + " - " + jaar;

        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
