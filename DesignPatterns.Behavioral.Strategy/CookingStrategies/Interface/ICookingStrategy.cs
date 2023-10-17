using DesignPatterns.Behavioral.Strategy.CookingStrategies.Enum;

namespace DesignPatterns.Behavioral.Strategy.CookingStrategies.Interface
{
    public interface ICookingStrategy
    {
        string Cook(string food);

        CookingStrategiesEnum CookingStrategy { get; }
    }
}