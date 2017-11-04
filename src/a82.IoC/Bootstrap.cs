using System;
using Microsoft.Extensions.DependencyInjection;
using a82.Domain;
using a82.Application;
using a82.Data;
using a82.Data.Mongo;

namespace a82.IoC
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services)
        {

             services.AddTransient(typeof(Repository<>));

            services.AddTransient(typeof(IProductApp), typeof(ProductApp));
            services.AddTransient(typeof(IProductRepository), typeof(ProductRepository));


        }
    }
}
