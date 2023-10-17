using DesignPatterns.Creational.FactoryMethod.Enum;

namespace DesignPatterns.Creational.FactoryMethod.Products
{
    public class HazelnutCookie : IFood
    {
        public FoodEnum FoodType => FoodEnum.HazelnutCookie;

        private readonly double _caloriesPerGram = 5.3;

        public double CalorieCount(double weight)
        {
            return weight * _caloriesPerGram;
        }
    }
}
