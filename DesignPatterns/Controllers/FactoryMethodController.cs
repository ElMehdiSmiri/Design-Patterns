using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.FactoryMethod.Enum;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactoryMethodController : ControllerBase
    {
        private readonly IFoodFactory _foodFactory;

        public FactoryMethodController(IFoodFactory foodFactory)
        {
            _foodFactory = foodFactory;
        }

        [HttpGet("/GetCaloriesForFoodType")]
        public IActionResult Get(int weight, FoodEnum foodtype)
        {
            var food = _foodFactory.CreateFood(foodtype);

            var calories = food.CalorieCount(weight);

            return Ok(calories);
        }
    }
}
