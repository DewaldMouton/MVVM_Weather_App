using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossWeatherApp.Core.Services
{
    public interface ISharedPreferencesService
    {
        string SharedPreferences { get; set; }
    }
}
