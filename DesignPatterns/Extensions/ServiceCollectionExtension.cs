using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.FactoryMethod.Products;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Behavioral.Strategy.CookingStrategies.Interface;
using DesignPatterns.Behavioral.Strategy.CookingStrategies;
using DesignPatterns.Behavioral.Strategy;

namespace DesignPatterns.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddSolutionServices(this IServiceCollection services)
        {
            services.AddStrategyServices();
            services.AddFactoryMethodServices();
            services.AddSingletonServices();
            services.AddObserverServices();
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

        public static void AddObserverServices(this IServiceCollection services)
        {
            services.AddSingleton<Behavioral.Observer.V1.IWeatherStation, Behavioral.Observer.V1.WeatherStation>();
            services.AddSingleton<Behavioral.Observer.V2.IWeatherStation, Behavioral.Observer.V2.WeatherStation>();
        }
    }
}
