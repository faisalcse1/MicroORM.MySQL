using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace MicroORM.MySQL
{
    public static class DatabaseContextServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabaseContext(this IServiceCollection services, Action<DatabaseContextOptions> setupOptions)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (setupOptions == null)
            {
                throw new ArgumentNullException(nameof(setupOptions));
            }
            services.AddOptions();
            services.Configure(setupOptions);
            services.TryAddSingleton<DatabaseContext>();
            return services;
        }


    }
}
