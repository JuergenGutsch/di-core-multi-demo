using Microsoft.Extensions.DependencyInjection;

namespace DiDemo.SqlDatabaseConnector
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddSqlDatabaseConnector(this IServiceCollection services)
        {
            services.AddTransient<ISqlDataService, SqlDataService>();
            services.AddTransient<ISqlDataProvider, SqlDataProvider>();
            return services;
        }
    }
}
