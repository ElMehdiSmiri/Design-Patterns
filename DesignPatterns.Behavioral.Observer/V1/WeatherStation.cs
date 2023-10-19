namespace DesignPatterns.Behavioral.Observer.V1
{
    public class WeatherStation : IWeatherStation
    {
        public event EventHandler<WeatherChangedEvent>? WeatherChanged;

        public void ReportWeather(string location, double temperature)
        {
            // Notify subscribers that weather conditions have changed
            WeatherChanged?.Invoke(this, new WeatherChangedEvent(location, temperature));
        }
    }
}
