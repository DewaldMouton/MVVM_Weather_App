using MvvmCrossWeatherApp.Core.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherAppXamarin.Core.dto;

namespace WeatherAppXamarin.Core.Services
{
    public class WeatherService : IWeatherService
    {
        private string URL = "http://api.openweathermap.org/data/2.5/weather?q=";
        private string MY_API = "&appid=cfd76b23e06c289ac93f5d12149badf1";

        private string IMAGE_URL = "http://openweathermap.org/img/w/";
        private string EXTENSION = ".png";

        private Forecast _forecast;
        private HttpClient _httpClient;
        private List<ItemDisplay> _forecastDetailList;
        private WeatherDetailService _weatherDetailService;
        DateTime time;

        public async Task<bool> GetWeatherAsync(string cityName)
        {
            _httpClient = new HttpClient();
            _forecast = new Forecast();
            var url = URL + cityName + MY_API;

            try
            {
                var response = await _httpClient.GetStringAsync(url);
                _forecast = JsonConvert.DeserializeObject<Forecast>(response);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public string GetCityName()
        {
            return ("Weather in " + _forecast.Name + ", " + _forecast.Sys.Country);
        }

        public string GetTemperature()
        {
            return ((_forecast.Main.Temp - 273.15) + " °C");
        }

        public string GetCondition()
        {
            return ((_forecast.Weather[0].Description.Substring(0, 1).ToUpper()) + _forecast.Weather[0].Description.Substring(1, _forecast.Weather[0].Description.Length - 1) + "");
        }

        public string GetTime()
        {
            time = (new DateTime(1970, 1, 1, 2, 0, 0)).AddMilliseconds((double)_forecast.DT * 1000L);
            return ("Last updated: " + string.Format("{0:g}", time));
        }

        public string GetImageUrl()
        {
            Console.WriteLine(IMAGE_URL + _forecast.Weather[0].Icon + EXTENSION);
            return IMAGE_URL + _forecast.Weather[0].Icon + EXTENSION;
        }

        public string GetWind()
        {
            return _weatherDetailService.CalculateWindSpeed(_forecast.Wind.Speed) + "\n" + _weatherDetailService.CalculateWindDirection(_forecast.Wind.Deg);
        }

        public string GetCloudiness()
        {
            return _forecast.Weather[0].Description.Substring(0, 1).ToUpper() + _forecast.Weather[0].Description.Substring(1, _forecast.Weather[0].Description.Length - 1) + "";
        }

        public string GetPressure()
        {
            return _forecast.Main.Pressure + " hpa";
        }

        public string GetHumidity()
        {
            return _forecast.Main.Humidity + " %";
        }

        public string GetSunrise()
        {
            return string.Format("{0:t}", (new DateTime(1970, 1, 1, 2, 0, 0)).AddMilliseconds((double)_forecast.Sys.Sunrise * 1000L));
        }

        public string GetSunset()
        {
            return string.Format("{0:t}", (new DateTime(1970, 1, 1, 2, 0, 0)).AddMilliseconds((double)_forecast.Sys.Sunset * 1000L));
        }

        public string GetGeoCoords()
        {
            return "[ " + _forecast.Coord.Lat + ", " + _forecast.Coord.Lon + " ]";
        }

        public List<ItemDisplay> GetForecastList()
        {
            _forecastDetailList = new List<ItemDisplay>();

            PopulateForecastList();

            return _forecastDetailList;
        }

        private void PopulateForecastList()
        {
            _weatherDetailService = new WeatherDetailService();

            _forecastDetailList.Add(new ItemDisplay("Wind", GetWind()));
            _forecastDetailList.Add(new ItemDisplay("Cloudiness", GetCloudiness()));
            _forecastDetailList.Add(new ItemDisplay("Pressure", GetPressure()));
            _forecastDetailList.Add(new ItemDisplay("Humidity", GetHumidity()));
            _forecastDetailList.Add(new ItemDisplay("Sunrise", GetSunrise()));
            _forecastDetailList.Add(new ItemDisplay("Sunset", GetSunset()));
            _forecastDetailList.Add(new ItemDisplay("Geo Coords", GetGeoCoords()));
        }
    }
}
