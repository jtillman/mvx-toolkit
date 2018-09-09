using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace $rootnamespace$
{
    public class $viewmodelname$ : MvxViewModel
    {
        private IMvxNavigationService _navigationService;

        public $viewmodelname$(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
