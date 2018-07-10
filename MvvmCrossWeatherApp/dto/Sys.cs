namespace WeatherAppXamarin.Core.dto
{
    public class Sys
    {

        public string Country { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
        public int ID { get; set; }
        public int Type { get; set; }
        public double Message { get; set; }

        public override string ToString()
        {
            return
                "Sys{" +
                "country = '" + Country + '\'' +
                ",sunrise = '" + Sunrise + '\'' +
                ",sunSet = '" + Sunset + '\'' +
                ",id = '" + ID + '\'' +
                ",type = '" + Type + '\'' +
                ",message = '" + Message + '\'' +
                "}";
        }
    }
}