using Application.Common.Interfaces;
using Application.Repositories;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IDateTimeService, DateTimeService>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IAttributeRepository, AttributeRepository>();

            services.AddTransient<ICategoryRepository, CategoryRepository>();

            services.AddTransient<IAttributeGroupRepository, AttributeGroupRepository>();

            return services;
        }
    }
}