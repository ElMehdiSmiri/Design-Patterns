using DesignPatterns.Strategy.CookingStrategies.Enum;
using DesignPatterns.Strategy.CookingStrategies.Interface;

namespace DesignPatterns.Strategy.CookingStrategies
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
