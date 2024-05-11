using Microsoft.Extensions.DependencyInjection;
using OGB.Application.Interfaces;
using OGB.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Application
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IClass1AService, Class1AService>();
            services.AddTransient<IClass1BService, Class1BService>();
            services.AddTransient<IClass1CService, Class1CService>();
            services.AddTransient<ITeacherService, TeacherService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
