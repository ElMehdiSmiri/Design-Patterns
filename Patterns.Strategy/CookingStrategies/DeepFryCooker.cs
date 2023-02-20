using DesignPatterns.Strategy.CookingStrategies.Enum;
using DesignPatterns.Strategy.CookingStrategies.Interface;

namespace DesignPatterns.Strategy.CookingStrategies
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
