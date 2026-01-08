using ePizza.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Infrastructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,string connectionString)
        {
            services.AddDbContext<EPizzaDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            return services;
        }
    }
}
