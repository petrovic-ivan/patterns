using Microsoft.Extensions.DependencyInjection;

namespace FactoryMethod
{
    public static class Startup
    {
        public static  T ConfigureEntryPoint<T>()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICreator, Creator>()
                .AddSingleton<IProduct, ProductA>()
                .AddSingleton<IProduct, ProductB>()
                .AddSingleton<IClient, Client>()
                .BuildServiceProvider();

            var entryPoint = serviceProvider.GetService<T>();
            return entryPoint;
        }
    }
}