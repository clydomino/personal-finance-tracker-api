using FinanceTracker.Domain;
using FinanceTracker.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Persistence.FinanceTrackerDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddScoped<IUserRepository, UserRepository>();
            
            return services;
        }
    }
}
