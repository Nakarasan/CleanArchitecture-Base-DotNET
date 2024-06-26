using CleanArchitecture.Application.Modules.Products.Services;
using CleanArchitecture.Domain.Entity.Products;
using CleanArchitecture.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shared.Utility.FileManipulator;
using Shared.Utility.FileManipulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infra
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddRegisteredServices(this IServiceCollection services, IConfiguration configuration)
        {
            /*services.AddDbContext<ApplicationDataContext>(options =>

                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection") ??
                    throw new InvalidOperationException("Connection string 'BlogBbContect' not found"))
            );*/
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IFileWriter, FileWriter >();
            return services;
        }
    }
}