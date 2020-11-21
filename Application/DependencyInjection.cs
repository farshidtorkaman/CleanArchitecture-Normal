using Application.Services.Attributes;
using Application.Services.AttributeGroups;
using Application.Services.Categories;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddTransient<IAttributeService, AttributeService>();

            services.AddTransient<ICategoryService, CategoryService>();

            services.AddTransient<IAttributeGroupService, AttributeGroupService>();

            return services;
        }
    }
}