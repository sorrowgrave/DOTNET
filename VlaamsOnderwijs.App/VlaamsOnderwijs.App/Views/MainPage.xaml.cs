using VlaamsOnderwijs.App.ViewModels;
using Windows.UI.Xaml.Controls;

namespace VlaamsOnderwijs.App.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Disabled;
        }

        private void AdaptiveVisualStateGroup_CurrentStateChanged(object sender, Windows.UI.Xaml.VisualStateChangedEventArgs e)
        {

        }

        private void SchoolListView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
