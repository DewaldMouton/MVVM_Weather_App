namespace MvvmCrossWeatherApp.Core.Services
{
    class WeatherDetailService : IWeatherDetailService
    {
        public string CalculateWindSpeed(double windSpeed)
        {
            string windRating = "";

            if (windSpeed < 0.3)
            {
                windRating = "Calm";
            }
            else if (windSpeed >= 0.3 && windSpeed < 1.6)
            {
                windRating = "Light Air";
            }
            else if (windSpeed >= 1.6 && windSpeed < 3.4)
            {
                windRating = "Light Breeze";
            }
            else if (windSpeed >= 3.4 && windSpeed < 5.5)
            {
                windRating = "Gentle Breeze";
            }
            else if (windSpeed >= 5.5 && windSpeed < 8)
            {
                windRating = "Moderate Breeze";
            }
            else if (windSpeed >= 8 && windSpeed < 10.8)
            {
                windRating = "Fresh Breeze";
            }
            else if (windSpeed >= 10.8 && windSpeed < 13.9)
            {
                windRating = "Strong Breeze";
            }
            else if (windSpeed >= 13.9 && windSpeed < 17.2)
            {
                windRating = "High Wind";
            }
            else if (windSpeed >= 17.2 && windSpeed < 20.8)
            {
                windRating = "Gale";
            }
            else if (windSpeed >= 20.8 && windSpeed < 24.5)
            {
                windRating = "Severe Gale";
            }
            else if (windSpeed >= 24.5 && windSpeed < 28.5)
            {
                windRating = "Storm";
            }
            else if (windSpeed >= 28.5 && windSpeed < 32.7)
            {
                windRating = "Violent Storm";
            }
            else if (windSpeed >= 32.7)
            {
                windRating = "Hurricane Force";
            }
            return windRating + " " + windSpeed + " m/s";
        }

        public string CalculateWindDirection(double windDeg)
        {
            string windDirection = "";

            if (windDeg == 0 || windDeg == 360)
            {
                windDirection = "North";
            }
            else if (windDeg > 0 && windDeg < 45)
            {
                windDirection = "North North-East";
            }
            else if (windDeg == 45)
            {
                windDirection = "North-East";
            }
            else if (windDeg > 45 && windDeg < 90)
            {
                windDirection = "East North-East";
            }
            else if (windDeg == 90)
            {
                windDirection = "East";
            }
            else if (windDeg > 90 && windDeg < 135)
            {
                windDirection = "East South-East";
            }
            else if (windDeg == 135)
            {
                windDirection = "South-East";
            }
            else if (windDeg > 135 && windDeg < 180)
            {
                windDirection = "South South-East";
            }
            else if (windDeg == 180)
            {
                windDirection = "South";
            }
            else if (windDeg > 180 && windDeg < 225)
            {
                windDirection = "South South-West";
            }
            else if (windDeg == 225)
            {
                windDirection = "South-West";
            }
            else if (windDeg > 225 && windDeg < 270)
            {
                windDirection = "West South-West";
            }
            else if (windDeg == 270)
            {
                windDirection = "West";
            }
            else if (windDeg > 270 && windDeg < 315)
            {
                windDirection = "West North-West";
            }
            else if (windDeg == 315)
            {
                windDirection = "North-West";
            }
            else if (windDeg > 315 && windDeg < 360)
            {
                windDirection = "West North-West";
            }
            return windDirection + " ( " + windDeg + " )";
        }
    }
}