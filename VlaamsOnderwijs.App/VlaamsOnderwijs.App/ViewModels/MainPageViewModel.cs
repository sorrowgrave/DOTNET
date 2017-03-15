using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;
using VlaamsOnderwijs.App.Services.SchoolService;
using VlaamsOnderwijs.ef;
using GalaSoft.MvvmLight.Messaging;
using Template10.Mvvm;
using Windows.UI.Xaml;

namespace VlaamsOnderwijs.App.ViewModels
{
    public class MainPageViewModel : Mvvm.ViewModelBase
    {
        private ISchoolService schoolService;
        string _currentState = "";
        public string CurrentState
        {
            get { return _currentState; }
            set
            {
                Set(ref _currentState, value);
                if (CurrentState == "NarrowState")
                    GotoDetailsPage();
            }
        }



        public MainPageViewModel(ISchoolService schoolService)
        {
            this.schoolService = schoolService;
        }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            Schools = await schoolService.GetSchools(1, 10);
        }

        ObservableCollection<School> _schools = default(ObservableCollection<School>);
        public ObservableCollection<School> Schools { get { return _schools; } private set { Set(ref _schools, value); } }

        string _searchText = default(string);
        public string SearchText { get { return _searchText; } set { Set(ref _searchText, value); } }

        School _selectedSchool = default(School);
        public School SelectedSchool
        {
            get { return _selectedSchool; }
            set
            {
                var message = value as School;
                Set(ref _selectedSchool, message);
            }
        }

        public void GotoDetailsPage()
        {
            NavigationService.Navigate(typeof(Views.DetailPage));
            Messenger.Default.Send<School>(SelectedSchool);
        }

        public void GotoPrivacy()
        {
            NavigationService.Navigate(typeof(Views.SettingsPage), 1);
        }

        public void GotoAbout()
        {
            NavigationService.Navigate(typeof(Views.SettingsPage), 2);
        }
        
        DelegateCommand _GotoDetailsCommand;
        public DelegateCommand GotoDetailsCommand
           => _GotoDetailsCommand ?? (_GotoDetailsCommand = new DelegateCommand(GotoDetailsCommandExecute, GotoDetailsCommandCanExecute));
        bool GotoDetailsCommandCanExecute() => true;
        void GotoDetailsCommandExecute()
        {
            GotoDetailsPage();
        }

        DelegateCommand _GotoPrivacyCommand;
        public DelegateCommand GotoPrivacyCommand
           => _GotoPrivacyCommand ?? (_GotoPrivacyCommand = new DelegateCommand(GotoPrivacyCommandExecute, GotoPrivacyCommandCanExecute));
        bool GotoPrivacyCommandCanExecute() => true;
        void GotoPrivacyCommandExecute()
        {
            NavigationService.Navigate(typeof(Views.SettingsPage), 1);
        }

        DelegateCommand _GotoAboutCommand;
        public DelegateCommand GotoAboutCommand
           => _GotoAboutCommand ?? (_GotoAboutCommand = new DelegateCommand(GotoAboutCommandExecute, GotoAboutCommandCanExecute));
        bool GotoAboutCommandCanExecute() => true;
        void GotoAboutCommandExecute()
        {
            NavigationService.Navigate(typeof(Views.SettingsPage), 1);
        }

        DelegateCommand _ItemClickedCommand;
        public DelegateCommand ItemClickedCommand
           => _ItemClickedCommand ?? (_ItemClickedCommand = new DelegateCommand(ItemClickedCommandExecute, ItemClickedCommandCanExecute));
        bool ItemClickedCommandCanExecute() => true;
        void ItemClickedCommandExecute()
        {
            NavigationService.Navigate(typeof(Views.DetailPage));
            Messenger.Default.Send<School>(SelectedSchool);
        }

    }
}

