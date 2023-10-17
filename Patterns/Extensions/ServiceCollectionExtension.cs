using DesignPatterns.Strategy.CookingStrategies.Interface;
using DesignPatterns.Strategy.CookingStrategies;
using DesignPatterns.Strategy;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.FactoryMethod.Products;
using DesignPatterns.Creational.Singleton;

namespace DesignPatterns.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddSolutionServices(this IServiceCollection services)
        {
            services.AddStrategyServices();
            services.AddFactoryMethodServices();
            services.AddSingletonServices();
        }

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

        public static void AddSingletonServices(this IServiceCollection services)
        {
            services.AddSingleton<ISingletonClass, SingletonClass>();
        }
    }
}
