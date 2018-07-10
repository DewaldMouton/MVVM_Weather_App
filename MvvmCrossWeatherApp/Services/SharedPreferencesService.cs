using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossWeatherApp.Core.Services
{
    class SharedPreferencesService : ISharedPreferencesService
    {
        private static ISettings _settings => CrossSettings.Current;

        public string SharedPreferences
        {
            get => _settings.GetValueOrDefault(nameof(SharedPreferences), string.Empty);
            set => _settings.AddOrUpdateValue(nameof(SharedPreferences), value);
        }
    }
}
