using Patterns.Strategy.ConcreteCookingStrategies.Enum;
using Patterns.Strategy.ConcreteCookingStrategies.Interface;

namespace Patterns.Strategy.ConcreteCookingStrategies
{
    public class RoastCooker : ICookingStrategy
    {
        public CookingStrategiesEnum CookingStrategy => CookingStrategiesEnum.Roast;

        public string Cook(string food)
        {
            return $"This {food} was roasted";
        }
    }
}
