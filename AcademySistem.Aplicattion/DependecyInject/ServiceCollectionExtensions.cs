using AcademySistem.Aplicattion.Service;
using AcademySistem.Infra.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySistem.Aplicattion.DependecyInject
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
