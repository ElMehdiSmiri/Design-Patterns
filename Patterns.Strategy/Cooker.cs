using Patterns.Strategy.ConcreteCookingStrategies.Enum;
using Patterns.Strategy.ConcreteCookingStrategies.Interface;

namespace Patterns.Strategy
{
    public class Cooker : ICooker
    {
        private IEnumerable<ICookingStrategy> _cookingServices;

        public Cooker(IEnumerable<ICookingStrategy> cookingServices)
        {
            _cookingServices = cookingServices;
        }

        public string CookMyFood(string food, CookingStrategiesEnum cookingStrategy)
        {
            var strategy = _cookingServices.Single(s => s.CookingStrategy == cookingStrategy);
            return strategy.Cook(food);
        }
    }
}
