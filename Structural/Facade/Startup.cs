using Microsoft.Extensions.DependencyInjection;

namespace Facade
{
    public static class Startup
    {
        public static  T ConfigureEntryPoint<T>()
        {

            var serviceProvider = new ServiceCollection()
                .AddSingleton<ISubsystemA, SubsystemA>()
                .AddSingleton<ISubsystemB, SubsystemB>()
                .AddSingleton<IFacade, FacadeSystem>()
                .AddSingleton<IClient, Client>()
                .BuildServiceProvider();

            var entryPoint = serviceProvider.GetService<T>();
            return entryPoint;
        }
    }
}