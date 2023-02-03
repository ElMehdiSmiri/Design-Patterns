using Patterns.Strategy.ConcreteCookingStrategies.Enum;
using Patterns.Strategy.ConcreteCookingStrategies.Interface;

namespace Patterns.Strategy.ConcreteCookingStrategies
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
