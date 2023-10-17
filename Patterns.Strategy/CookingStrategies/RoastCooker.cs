using DesignPatterns.Behavioral.Strategy.CookingStrategies.Enum;
using DesignPatterns.Behavioral.Strategy.CookingStrategies.Interface;

namespace DesignPatterns.Behavioral.Strategy.CookingStrategies
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
