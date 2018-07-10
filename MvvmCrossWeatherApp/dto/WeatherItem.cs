namespace WeatherAppXamarin.Core.dto
{
    public class WeatherItem
    {

        public string Icon { get; set; }
        public string Description { get; set; }
        public string Main { get; set; }
        public int ID { get; set; }

        public override string ToString()
        {
            return
                    "WeatherItem{" +
                            "icon = '" + Icon + '\'' +
                            ",description = '" + Description + '\'' +
                            ",main = '" + Main + '\'' +
                            ",id = '" + ID + '\'' +
                            "}";
        }

    }
}