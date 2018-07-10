namespace WeatherAppXamarin.Core.dto
{
    public class ItemDisplay
    {

        public string FieldName { get; set; }
        public string FieldValue { get; set; }

        public ItemDisplay()
        {

        }

        public ItemDisplay(string fieldName, string value)
        {
            this.FieldName = fieldName;
            this.FieldValue = value;
        }

        public override string ToString()
        {
            return FieldName + " : " + FieldValue;
        }
    }
}