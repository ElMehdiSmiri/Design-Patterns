using DesignPatterns.Strategy.CookingStrategies.Enum;
using DesignPatterns.Strategy.CookingStrategies.Interface;

namespace DesignPatterns.Strategy.CookingStrategies
{
    public class GrillCooker : ICookingStrategy
    {
        public CookingStrategiesEnum CookingStrategy => CookingStrategiesEnum.Grill;

        public string Cook(string food)
        {
            return $"This {food} was grilled";
        }
    }
}
