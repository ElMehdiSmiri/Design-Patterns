using DesignPatterns.Creational.FactoryMethod.Enum;

namespace DesignPatterns.Creational.FactoryMethod.Products
{
    public class Milk : IFood
    {
        public FoodEnum FoodType => FoodEnum.Milk;

        private readonly double _caloriesPerGram = 0.42;

        public double CalorieCount(double weight)
        {
            return weight * _caloriesPerGram;
        }
    }
}
