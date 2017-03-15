using Microsoft.Practices.ServiceLocation;
using VlaamsOnderwijs.App.Services.SchoolService;
using VlaamsOnderwijs.DAL;
using GalaSoft.MvvmLight.Ioc;

namespace VlaamsOnderwijs.App.ViewModels
{
    public class ViewModelLocator
    {
        private ISchoolService schoolService = new SchoolService(new SchoolRepository());

        //public ViewModelLocator()
        //{
        //    ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

        //    SimpleIoc.Default.Register<ISchoolService, SchoolService>();
        //    SimpleIoc.Default.Register<MainPageViewModel>();
        //    SimpleIoc.Default.Register<DetailPageViewModel>();
        //}

        //public MainPageViewModel MainPageViewModel
        //{
        //    get
        //    {
        //        return ServiceLocator.Current.GetInstance<MainPageViewModel>();
        //    }
        //}

        //public DetailPageViewModel DetailPageViewModel
        //{
        //    get
        //    {
        //        return ServiceLocator.Current.GetInstance<DetailPageViewModel>();
        //    }
        //}

        private MainPageViewModel _MainPageViewModel;
        public MainPageViewModel MainPageViewModel =>
                _MainPageViewModel ?? (_MainPageViewModel = new MainPageViewModel(schoolService));

        private DetailPageViewModel _DetailPageViewModel;
        public DetailPageViewModel DetailPageViewModel =>
                _DetailPageViewModel ?? (_DetailPageViewModel = new DetailPageViewModel(schoolService));
    }
}
