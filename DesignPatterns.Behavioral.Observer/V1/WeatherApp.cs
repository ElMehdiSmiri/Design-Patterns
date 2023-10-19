namespace DesignPatterns.Behavioral.Observer.V1
{
    public class WeatherApp
    {
        private readonly string _location;

        public WeatherApp(string location)
        {
            _location = location;
        }

        public void UpdateWeather(object sender, WeatherChangedEvent e)
        {
            if (e.Location == _location)
            {
                Console.WriteLine($"WeatherApp for {_location}: Temperature = {e.Temperature}°C");
            }
        }
    }
}
