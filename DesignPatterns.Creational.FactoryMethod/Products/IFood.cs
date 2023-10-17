using DesignPatterns.Creational.FactoryMethod.Enum;

namespace DesignPatterns.Creational.FactoryMethod.Products
{
    public interface IFood
    {
        FoodEnum FoodType { get; }

        public double CalorieCount(double weight);
    }
}
