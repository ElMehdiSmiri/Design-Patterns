using Patterns.Strategy.ConcreteCookingStrategies.Enum;
using Patterns.Strategy.ConcreteCookingStrategies.Interface;

namespace Patterns.Strategy.ConcreteCookingStrategies
{
    public class DeepFryCooker : ICookingStrategy
    {
        public CookingStrategiesEnum CookingStrategy => CookingStrategiesEnum.DeepFry;

        public string Cook(string food)
        {
            return $"This {food} was deep fried";
        }
    }
}
