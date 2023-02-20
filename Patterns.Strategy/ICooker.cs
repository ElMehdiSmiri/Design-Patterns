using DesignPatterns.Strategy.CookingStrategies.Enum;

namespace DesignPatterns.Strategy
{
    public interface ICooker
    {
        string CookMyFood(string food, CookingStrategiesEnum cookingStrategy);
    }
}
