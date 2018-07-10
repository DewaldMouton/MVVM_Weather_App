using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossWeatherApp.Core.Services
{
    interface IWeatherDetailService
    {
        string CalculateWindSpeed(double windSpeed);
        string CalculateWindDirection(double windDeg);
    }
}
