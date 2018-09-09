using MvvmCross.Forms.Core;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MvxTemplate.Forms
{
    public partial class App : MvxFormsApplication
    {
        public App()
        {
            InitializeComponent();
        }
    }
}
