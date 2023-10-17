using DesignPatterns.FactoryMethod.Enum;
using DesignPatterns.FactoryMethod.Products;

namespace DesignPatterns.FactoryMethod
{
    public interface IFoodFactory
    {
        IFood CreateFood(FoodEnum food);
    }
}
