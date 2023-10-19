namespace DesignPatterns.Behavioral.Observer.V2
{
    // Define the WeatherStation (Publisher) interface
    public interface IWeatherStation
    {
        int Temperature { get; set; }

        void RegisterApp(IWeatherApp app);

        void UnregisterApp(IWeatherApp app);

        void NotifyApps();
    }
}
