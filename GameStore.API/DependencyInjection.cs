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
            services.AddTransient<IAlquilerServices, AlquilerServices>();
            services.AddTransient<IClienteServices, ClienteServices>();
            services.AddTransient<IDirectorServices, DirectorServices>();
            services.AddTransient<IEstadoServices, EstadoServices>();
            services.AddTransient<IJuegoServices, JuegoServices>();
            services.AddTransient<IMarcaServices, MarcaServices>();
            services.AddTransient<IPlataformaServices, PlataformaServices>();
            services.AddTransient<IProtagonistaServices, ProtagonistaServices>();
            
            return services;
        }
    }
}
