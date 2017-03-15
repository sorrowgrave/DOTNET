using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;
using Template10.Mvvm;
using Template10.Services.NavigationService;
using VlaamsOnderwijs.App.Services.SchoolService;
using VlaamsOnderwijs.ef;
using Windows.UI.Xaml.Navigation;

namespace VlaamsOnderwijs.App.ViewModels
{
    public class DetailPageViewModel : Mvvm.ViewModelBase
    {
        private ISchoolService schoolService;
        private School _selectedSchool;
        public School SelectedSchool
        {
            get
            {
                return _selectedSchool;
            }
            set
            {
                Set(ref _selectedSchool, value);
            }
        }
        //public School SelectedSchool { get { return _selectedSchool; } set { Set(ref _selectedSchool, value); } }

        public DetailPageViewModel(ISchoolService schoolService)
        {
            this.schoolService = schoolService;

            Messenger.Default.Register<School>(this, OnSchoolReceived);
        }

        public void OnSchoolReceived(School school)
        {
            SelectedSchool = school;
        }
    }
}

