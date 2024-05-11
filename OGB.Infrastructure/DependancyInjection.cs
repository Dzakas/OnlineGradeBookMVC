using Microsoft.Extensions.DependencyInjection;
using OGB.Domain.Interfaces;
using OGB.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Infrastructure
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IClass1ARepository, Class1ARepository>();
            services.AddTransient<IClass1BRepository, Class1BRepository>();
            services.AddTransient<IClass1CRepository, Class1CRepository>();
            services.AddTransient<ITeacherRepository, TeacherRepository>();
            return services;
        }
    }
}
