using Microsoft.AspNetCore.Mvc;
using Patterns.Strategy;
using Patterns.Strategy.ConcreteCookingStrategies.Enum;

namespace Patterns.Controllers
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
