using Microsoft.Extensions.DependencyInjection;

namespace Bridge
{
    public static class Startup
    {
        public static  T ConfigureEntryPoint<T>()
        {

            var serviceProvider = new ServiceCollection()
                .AddSingleton<IBridge, AirplaneImplementation>()
                .AddSingleton<IBridge, BoatImplementation>()
                .AddSingleton<IAbstraction, Abstraction>()
                .AddSingleton<IClient, Client>()
                .BuildServiceProvider();

            var entryPoint = serviceProvider.GetService<T>();
            return entryPoint;
        }
    }
}