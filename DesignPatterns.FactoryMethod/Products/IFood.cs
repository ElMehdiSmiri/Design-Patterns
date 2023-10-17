using DesignPatterns.FactoryMethod.Enum;

namespace DesignPatterns.FactoryMethod.Products
{
    public interface IFood
    {
        FoodEnum FoodType { get; }

        public double CalorieCount(double weight);
    }
}
