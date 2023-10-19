namespace DesignPatterns.Behavioral.Observer.V2
{
    // Concrete WeatherStation (Concrete Publisher)
    public class WeatherStation : IWeatherStation
    {
        private readonly List<IWeatherApp> _apps = new();
        private int _temperature;

        public int Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                NotifyApps(); // Notify WeatherApps when the temperature changes
            }
        }

        public void RegisterApp(IWeatherApp app)
        {
            _apps.Add(app);
        }

        public void UnregisterApp(IWeatherApp app)
        {
            _apps.Remove(app);
        }

        public void NotifyApps()
        {
            foreach (var app in _apps)
            {
                app.Update(_temperature);
            }
        }
    }
}
