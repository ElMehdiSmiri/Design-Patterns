using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObserverController : ControllerBase
    {
        private readonly Behavioral.Observer.V1.IWeatherStation _weatherStationV1;
        private readonly Behavioral.Observer.V2.IWeatherStation _weatherStationV2;

        public ObserverController(Behavioral.Observer.V1.IWeatherStation weatherStationV1, Behavioral.Observer.V2.IWeatherStation weatherStationV2)
        {
            _weatherStationV1 = weatherStationV1;
            _weatherStationV2 = weatherStationV2;
        }

        [HttpGet("/V1/SendWeatherUpdate")]
        public IActionResult Get(string location, double Temperature)
        {
            Behavioral.Observer.V1.WeatherApp app1 = new(location);
            Behavioral.Observer.V1.WeatherApp app2 = new("Bali");

            // Subscribe app1 and app2 to weather updates
            _weatherStationV1.WeatherChanged += app1.UpdateWeather!;
            _weatherStationV1.WeatherChanged += app2.UpdateWeather!;

            _weatherStationV1.ReportWeather(location, Temperature);
            _weatherStationV1.ReportWeather("Bali", Temperature);

            // Unsubscribe app1
            _weatherStationV1.WeatherChanged -= app1.UpdateWeather!;

            return Ok();
        }

        [HttpGet("/V2/SendWeatherUpdate")]
        public IActionResult Get(int Temperature)
        {

            // Create some WeatherApps
            Behavioral.Observer.V2.WeatherApp app1 = new("WeatherApp 1");
            Behavioral.Observer.V2.WeatherApp app2 = new("WeatherApp 2");

            // Register the WeatherApps with the WeatherStation
            _weatherStationV2.RegisterApp(app1);
            _weatherStationV2.RegisterApp(app2);

            // Simulate a change in temperature, and WeatherApps will be notified
            _weatherStationV2.Temperature = Temperature;

            // Unregister a WeatherApp
            _weatherStationV2.UnregisterApp(app2);

            // Simulate another change in temperature, and only the remaining WeatherApp will be notified
            _weatherStationV2.Temperature = 30;

            return Ok();
        }
    }
}
