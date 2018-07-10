using System;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;
using MvvmCrossWeatherApp.Core.Services;
using WeatherAppXamarin.Core.dto;
using WeatherAppXamarin.Core.Services;

namespace MvvmCrossWeatherApp.Core.ViewModels
{
    public class ForecastDetailModel : MvxViewModel
    {
        IWeatherService _weatherService;
        ITextToSpeechService _textToSpeechService;

        private string _cityName;
        private string _temperature;
        private string _condition;
        private string _time;
        private string _imageUrl;
        private List<ItemDisplay> _forecastList;
        private MvxCommand _readForecast;

        public ForecastDetailModel(IWeatherService weatherService, ITextToSpeechService textToSpeechService)
        {
            _weatherService = weatherService;
            _textToSpeechService = textToSpeechService;

            InitData();
        }

        private void InitData()
        {
            GetCityName = _weatherService.GetCityName();
            GetTemperature = _weatherService.GetTemperature();
            GetCondition = _weatherService.GetCondition();
            GetTime = _weatherService.GetTime();
            GetImageUrl = _weatherService.GetImageUrl();
            GetForecastList = _weatherService.GetForecastList();
        }

        public string GetCityName
        {
            get => _cityName;
            set => SetProperty(ref _cityName, value);
        }

        public string GetTemperature
        {
            get => _temperature;
            set => SetProperty(ref _temperature, value);
        }

        public string GetCondition
        {
            get => _condition;
            set => SetProperty(ref _condition, value);
        }

        public string GetTime
        {
            get => _time;
            set => SetProperty(ref _time, value);
        }

        public string GetImageUrl
        {
            get => _imageUrl;
            set => SetProperty(ref _imageUrl, value);
        }

        public List<ItemDisplay> GetForecastList
        {
            get => _forecastList;
            set => SetProperty(ref _forecastList, value);
        }

        public IMvxCommand ReadForecastCommand
        {
            get
            {
                _readForecast = _readForecast ?? new MvxCommand(ReadForecast);
                return _readForecast;
            }
        }

        public void ReadForecast()
        {
            var text = GetCityName + " is " + GetTemperature + ". Expect " + GetCondition;
            _textToSpeechService.TextToSpeech(text);
        }
    }
}
