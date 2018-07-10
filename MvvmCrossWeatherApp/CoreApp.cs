using MvvmCross.Platform.IoC;
using WeatherAppXamarin.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using WeatherAppXamarin.Core.Services;
using MvvmCross.Platform;
using MvvmCrossWeatherApp.Core.Services;

namespace MvvmCrossWeatherApp.Core
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.LazyConstructAndRegisterSingleton<IWeatherService, WeatherService>();
            Mvx.LazyConstructAndRegisterSingleton<ISharedPreferencesService, SharedPreferencesService>();
            Mvx.LazyConstructAndRegisterSingleton<ITextToSpeechService, TextToSpeechService>();

            RegisterNavigationServiceAppStart<MainViewModel>();
        }
    }
}
