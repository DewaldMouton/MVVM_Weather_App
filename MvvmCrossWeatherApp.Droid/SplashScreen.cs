using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Droid.Views;

namespace MvvmCrossWeatherApp.Droid
{
    [Activity(
        Label = "Open Weather"
        , MainLauncher = true
        , Theme = "@style/OpenWeatherNoTitle"
        )]

    public class SplashScreen : MvxSplashScreenActivity
    {
        ImageView icon;
        
        public SplashScreen() : base(Resource.Layout.SplashScreen)
        {
        }

        protected override void TriggerFirstNavigate()
        {
            StartActivity(typeof(MainView));
            base.TriggerFirstNavigate();
        }

        //protected override void OnCreate(Bundle bundle)
        //{
        //    base.OnCreate(bundle); 
        //}
    }
}