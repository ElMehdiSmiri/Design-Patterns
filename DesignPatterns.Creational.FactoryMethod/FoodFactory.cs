using DesignPatterns.Creational.FactoryMethod.Enum;
using DesignPatterns.Creational.FactoryMethod.Products;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class FoodFactory : IFoodFactory
    {
        private readonly IEnumerable<IFood> _foods;

        public FoodFactory(IEnumerable<IFood> foods)
        {
            _foods = foods;
        }

        public IFood CreateFood(FoodEnum food)
        {
            return _foods.Single(s => s.FoodType == food);
        }
    }
}
