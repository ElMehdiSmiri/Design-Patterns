using DesignPatterns.Strategy.CookingStrategies.Enum;

namespace DesignPatterns.Strategy.CookingStrategies.Interface
{
    public interface ICookingStrategy
    {
        string Cook(string food);

        CookingStrategiesEnum CookingStrategy { get; }
    }
}