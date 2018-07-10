
using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using MvvmCrossWeatherApp.Core.ViewModels;

namespace MvvmCrossWeatherApp.Droid
{
    [Activity(Label = "Open Weather", Theme = "@style/OpenWeather")]

    public class ForecastDetailView : MvxActivity<ForecastDetailModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ForecastDetail);
        }
    }
}