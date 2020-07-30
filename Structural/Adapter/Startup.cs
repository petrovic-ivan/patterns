using Microsoft.Extensions.DependencyInjection;

namespace Adapter
{
    public static class Startup
    {
        public static  T ConfigureEntryPoint<T>()
        {

            var serviceProvider = new ServiceCollection()
                .AddSingleton<IClient, Client>()
                .AddSingleton<ITarget, Adapter>()
                .AddSingleton<IAdaptee, Adaptee>()
                .BuildServiceProvider();

            var entryPoint = serviceProvider.GetService<T>();
            return entryPoint;
        }
    }
}