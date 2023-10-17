using DesignPatterns.Creational.FactoryMethod.Enum;
using DesignPatterns.Creational.FactoryMethod.Products;

namespace DesignPatterns.Creational.FactoryMethod
{
    public interface IFoodFactory
    {
        IFood CreateFood(FoodEnum food);
    }
}
