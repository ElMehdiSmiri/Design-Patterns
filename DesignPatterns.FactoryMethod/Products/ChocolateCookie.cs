using DesignPatterns.FactoryMethod.Enum;

namespace DesignPatterns.FactoryMethod.Products
{
    public class ChocolateCookie : IFood
    {
        public FoodEnum FoodType => FoodEnum.ChocolateCookie;

        private readonly double _caloriesPerGram = 4.8;

        public double CalorieCount(double weight)
        {
            return weight * _caloriesPerGram;
        }
    }
}
