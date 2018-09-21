using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Forms.Platforms.Android.Views;

namespace MvxTemplate.Forms.Droid
{
    [Activity(Label = "MvvmCross.Forms",
        Icon = "@mipmap/icon",
        Theme = "@style/MainTheme",
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MvxFormsAppCompatActivity<Setup, CoreApp, App>
    {
        protected override void OnCreate(Bundle bundle)
        {
            SetTheme(Resource.Style.MainTheme);
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
        }
    }
}