using Patterns.Strategy.ConcreteCookingStrategies.Enum;

namespace Patterns.Strategy.ConcreteCookingStrategies.Interface
{
    public interface ICookingStrategy
    {
        string Cook(string food);

        CookingStrategiesEnum CookingStrategy { get; }
    }
}