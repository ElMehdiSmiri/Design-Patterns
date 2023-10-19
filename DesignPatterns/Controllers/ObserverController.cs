using DesignPatterns.Behavioral.Observer.V1;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObserverController : ControllerBase
    {
        private readonly IWeatherStation _weatherStation;

        public ObserverController(IWeatherStation weatherStation)
        {
            _weatherStation = weatherStation;
        }

        [HttpGet("/SendWeatherUpdate")]
        public IActionResult Get(string location, double Temperature)
        {
            WeatherApp app1 = new(location);
            WeatherApp app2 = new("Bali");

            _weatherStation.WeatherChanged += app1.UpdateWeather!;
            _weatherStation.WeatherChanged += app2.UpdateWeather!;

            _weatherStation.ReportWeather(location, Temperature);
            _weatherStation.ReportWeather("Bali", Temperature);


            return Ok();
        }
    }
}
