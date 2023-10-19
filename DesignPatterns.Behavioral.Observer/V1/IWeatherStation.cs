namespace DesignPatterns.Behavioral.Observer.V1
{
    public interface IWeatherStation
    {
        event EventHandler<WeatherChangedEvent> WeatherChanged;

        void ReportWeather(string location, double temperature);
    }
}
