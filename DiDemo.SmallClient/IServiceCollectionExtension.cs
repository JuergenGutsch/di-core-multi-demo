using Microsoft.Extensions.DependencyInjection;

namespace DiDemo.SmallClient
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddInternalServices(this IServiceCollection services)
        {
            services.AddTransient<IWriteSimpleDataService, WriteSimpleDataService>();
            return services;
        }
    }
}
