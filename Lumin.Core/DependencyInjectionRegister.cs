using Lumin.Core.Interfaces;
using Lumin.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Lumin.Core
{
    public static class DependencyInjectionRegister
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddScoped<IManifestService, ManifestService>();

            return services;
        }
    }
}
