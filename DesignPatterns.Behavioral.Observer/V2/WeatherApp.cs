namespace DesignPatterns.Behavioral.Observer.V2
{
    // Concrete WeatherApp (Concrete Subscriber)
    public class WeatherApp : IWeatherApp
    {
        private string _appName;

        public WeatherApp(string name)
        {
            _appName = name;
        }

        public void Update(int temperature)
        {
            Console.WriteLine($"{_appName} received an update. New temperature: {temperature}°C");
        }
    }
}
