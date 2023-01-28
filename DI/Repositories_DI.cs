using BlazorCrud.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorCrud.DI
{
    public static class Repositories_DI
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            return services;
        }
    }
}
