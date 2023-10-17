using DesignPatterns.FactoryMethod.Enum;

namespace DesignPatterns.FactoryMethod.Products
{
    public class OrangeJuice : IFood
    {
        public FoodEnum FoodType => FoodEnum.OrangeJuice;

        private readonly double _caloriesPerGram = 0.45;

        public double CalorieCount(double weight)
        {
            return weight * _caloriesPerGram;
        }
    }
}
