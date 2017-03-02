using Microsoft.Extensions.DependencyInjection;

namespace DiDemo.BigClient
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddInternalServices(this IServiceCollection services)
        {
            services.AddTransient<IWriteExtendedDataService, WriteExtendedDataService>();
            services.AddTransient<INormalizedDataService, NormalizedDataService>();
            return services;
        }
    }
}
