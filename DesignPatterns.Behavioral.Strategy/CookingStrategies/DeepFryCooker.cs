using DesignPatterns.Behavioral.Strategy.CookingStrategies.Enum;
using DesignPatterns.Behavioral.Strategy.CookingStrategies.Interface;

namespace DesignPatterns.Behavioral.Strategy.CookingStrategies
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
