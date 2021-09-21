using GameStore.API.Interfaces;
using GameStore.API.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCustomizedServices(this IServiceCollection services)
        {
            services.AddTransient<IEstadoServices, EstadoServices>();
            services.AddTransient<IMarcaServices, MarcaServices>();

            return services;
        }
    }
}
