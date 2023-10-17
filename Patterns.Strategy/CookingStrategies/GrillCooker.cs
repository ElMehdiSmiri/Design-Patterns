using DesignPatterns.Behavioral.Strategy.CookingStrategies.Enum;
using DesignPatterns.Behavioral.Strategy.CookingStrategies.Interface;

namespace DesignPatterns.Behavioral.Strategy.CookingStrategies
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
