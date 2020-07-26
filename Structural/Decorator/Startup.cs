using Microsoft.Extensions.DependencyInjection;

namespace Decorator
{
    public static class Startup
    {
        public static  T ConfigureEntryPoint<T>()
        {

            var serviceProvider = new ServiceCollection()
                .AddSingleton<IComponent, Component>()
                .Decorate<IComponent, Decorator>()
                .AddSingleton<IClient, Client>()
                .BuildServiceProvider();

            var entryPoint = serviceProvider.GetService<T>();
            return entryPoint;
        }
    }
}