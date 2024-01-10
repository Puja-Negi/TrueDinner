using Microsoft.Extensions.DependencyInjection;
using TrueDinner.Application.Services.Authentication;

namespace TrueDinner.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            return services;
        }
    }
}