namespace WeatherAppXamarin.Core.dto
{
    public class Wind
    {

        public int Deg { get; set; }
        public double Speed { get; set; }

        public override string ToString()
        {
            return
                "Wind{" +
                "deg = '" + Deg + '\'' +
                ",speed = '" + Speed + '\'' +
                "}";
        }
    }
}