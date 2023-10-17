using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.Strategy.CookingStrategies.Enum;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StrategyController : ControllerBase
    {
        private readonly ICooker _cooker;

        public StrategyController(ICooker cooker)
        {
            _cooker = cooker;
        }

        [HttpGet("/SendMeSomefood")]
        public IActionResult Get(string food, CookingStrategiesEnum cookingStrategy)
        {
            return Ok(_cooker.CookMyFood(food, cookingStrategy));
        }
    }
}
