using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherAppXamarin.Core.dto;

namespace WeatherAppXamarin.Core.Services
{
    public interface IWeatherService
    {
        Task<bool> GetWeatherAsync(string cityName);
        string GetCityName();
        string GetTemperature();
        string GetCondition();
        string GetTime();
        string GetImageUrl();
        List<ItemDisplay> GetForecastList();
    }
}
