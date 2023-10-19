namespace DesignPatterns.Behavioral.Observer.V1
{
    public class WeatherChangedEvent : EventArgs
    {
        public string Location { get; }

        public double Temperature { get; }


        public WeatherChangedEvent(string location, double temperature)
        {
            Location = location;
            Temperature = temperature;
        }
    }
}
