using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Xamarin.Forms.Xaml;

namespace MvxTemplate.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxNavigationPagePresentation(Animated = true)]
    public partial class MainPageView : MvxContentPage<MainPageViewModel>
    {
        public MainPageView()
        {
            InitializeComponent();
        }
    }
}