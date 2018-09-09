using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace $rootnamespace$
{
    public class $safeitemname$ : MvxViewModel
    {
        private IMvxNavigationService _navigationService;

        public $safeitemname$(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
