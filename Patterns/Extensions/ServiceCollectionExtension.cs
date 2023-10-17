using DesignPatterns.Strategy.CookingStrategies.Interface;
using DesignPatterns.Strategy.CookingStrategies;
using DesignPatterns.Strategy;
using DesignPatterns.FactoryMethod;
using DesignPatterns.FactoryMethod.Products;

namespace DesignPatterns.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddStrategyServices(this IServiceCollection services)
        {
            services.AddScoped<ICooker, Cooker>();
            services.AddScoped<ICookingStrategy, DeepFryCooker>();
            services.AddScoped<ICookingStrategy, GrillCooker>();
            services.AddScoped<ICookingStrategy, RoastCooker>();
        }

        public static void AddFactoryMethodServices(this IServiceCollection services)
        {
            services.AddScoped<IFoodFactory, FoodFactory>();
            services.AddScoped<IFood, ChocolateCookie>();
            services.AddScoped<IFood, HazelnutCookie>();
            services.AddScoped<IFood, Milk>();
            services.AddScoped<IFood, OrangeJuice>();
        }
    }
}
