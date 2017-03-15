using MahApps.Metro.Controls;
using System.Linq;
using System.Windows;

namespace FashionZone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ControlPanel : MetroWindow
    {
        public ControlPanel()
        {
            InitializeComponent();
        }


        private void inventoryButton_Click(object sender, RoutedEventArgs e)
        {
            bool iswindowopen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Beheer)
                {
                    iswindowopen = true;
                    w.Activate();
                }
            }

            if (!iswindowopen)
            {
                Beheer newwindow = new Beheer();
                newwindow.Show();
            }

            //var existingWindow = Application.Current.Windows.Cast<Window>().SingleOrDefault(w => /* return "true" if 'w' is the window your are about to open */);

            //if (existingWindow != null)
            //{
            //    existingWindow.Activate();
            //}
            //else
            //{
            //    Beheer newwindow = new Beheer();
            //    newwindow.Show();
            //}
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
