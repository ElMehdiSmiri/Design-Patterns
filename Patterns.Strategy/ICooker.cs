using DesignPatterns.Behavioral.Strategy.CookingStrategies.Enum;

namespace DesignPatterns.Behavioral.Strategy
{
    public interface ICooker
    {
        string CookMyFood(string food, CookingStrategiesEnum cookingStrategy);
    }
}
