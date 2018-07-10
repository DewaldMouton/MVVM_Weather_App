using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using MvvmCross.Droid.Views;
using WeatherAppXamarin.Core.ViewModels;

namespace MvvmCrossWeatherApp.Droid
{
    [Activity(Label = "Open Weather", Theme = "@style/OpenWeather")]
    public class MainView : MvxActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            //StoreCityName(ViewModel.CityName);
            //RetrieveCityName();
        }

        public void StoreCityName(string cityName)
        {
            ISharedPreferences mSharedPreference = GetSharedPreferences("CityName", FileCreationMode.Private);
            ISharedPreferencesEditor mEditor = mSharedPreference.Edit();
            mEditor.PutString("CityName", cityName);
            mEditor.Apply();
        }

        public string RetrieveCityName()
        {
            ISharedPreferences mSharedPreference = GetSharedPreferences("CityName", FileCreationMode.Private);
            string previousCity = mSharedPreference.GetString("CityName", null);
            return previousCity;
        }
    }
}

