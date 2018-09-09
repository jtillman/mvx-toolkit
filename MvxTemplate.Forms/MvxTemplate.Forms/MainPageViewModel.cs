using MvvmCross.Navigation;
using MvvmCross.ViewModels;


namespace MvxTemplate.Forms
{
    public class MainPageViewModel : MvxViewModel
    {
        private IMvxNavigationService _navigationService;

        public MainPageViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}