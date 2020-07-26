using Microsoft.Extensions.DependencyInjection;

namespace Proxy
{
    public static class Startup
    {
        public static  T ConfigureEntryPoint<T>()
        {

            var serviceProvider = new ServiceCollection()
                .AddSingleton<IProxy, AuthProxy>()
                .AddSingleton<IClient, Client>()
                .BuildServiceProvider();

            var entryPoint = serviceProvider.GetService<T>();
            return entryPoint;
        }
    }
}