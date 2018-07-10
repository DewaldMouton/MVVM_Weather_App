namespace WeatherAppXamarin.Core.dto
{
    public class Coord
    {

        public double Lon { get; set; }
        public double Lat { get; set; }

        public override string ToString()
        {
            return
                "Coord{" +
                "lon = '" + Lon + '\'' +
                ",lat = '" + Lat + '\'' +
                "}";
        }
    }
}