using Patterns.Strategy.ConcreteCookingStrategies.Enum;

namespace Patterns.Strategy
{
    public interface ICooker
    {
        string CookMyFood(string food, CookingStrategiesEnum cookingStrategy);
    }
}
