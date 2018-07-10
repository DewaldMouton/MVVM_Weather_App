using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCrossWeatherApp.Core.Services;
using MvvmCrossWeatherApp.Core.ViewModels;
using System;
using WeatherAppXamarin.Core.Services;

namespace WeatherAppXamarin.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private string _cityName;
        private bool _loading;
        private MvxCommand _getForecastCommand;

        IWeatherService _weatherService;
        IMvxNavigationService _navigationService;
        ISharedPreferencesService _sharedPreferencesService;

        public MainViewModel(IWeatherService weatherService, IMvxNavigationService navigationService, ISharedPreferencesService sharedPreferencesService)
        {
            _weatherService = weatherService;
            _navigationService = navigationService;
            _sharedPreferencesService = sharedPreferencesService;

            var storedCityName = _sharedPreferencesService.SharedPreferences;

            if (!string.IsNullOrEmpty(storedCityName))
            {
                CityName = storedCityName;
            }
        }

        public string CityName
        {
            get => _cityName;
            set => SetProperty(ref _cityName, value);
        }

        public bool Loading
        {
            get => _loading;
            set => SetProperty(ref _loading, value);
        }

        public IMvxCommand GetForecastCommand
        {
            get
            {
                _getForecastCommand = _getForecastCommand ?? new MvxCommand(GetForecast);
                return _getForecastCommand;
            }
        }

        public async void GetForecast()
        {
            Loading = true;
            if (await _weatherService.GetWeatherAsync(_cityName))
            {
                _sharedPreferencesService.SharedPreferences = CityName;
                await _navigationService.Navigate<ForecastDetailModel>();
                Loading = false;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}