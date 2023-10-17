using DesignPatterns.FactoryMethod.Enum;
using DesignPatterns.FactoryMethod.Products;

namespace DesignPatterns.FactoryMethod
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
