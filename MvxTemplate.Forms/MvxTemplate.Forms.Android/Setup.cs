using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.Logging;
using Serilog;

namespace MvxTemplate.Forms.Droid
{
    public class Setup : MvxFormsAndroidSetup<CoreApp, App>
    {
        public override MvxLogProviderType GetDefaultLogProviderType()
            => MvxLogProviderType.Serilog;

        protected override IMvxLogProvider CreateLogProvider()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.AndroidLog()
                .CreateLogger();
            return base.CreateLogProvider();
        }
    }
}