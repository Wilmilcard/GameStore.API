using GameStore.Domain.DB;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Domain.Repository;

namespace GameStore.Domain
{
    public static class DependecyInjection
    {
        //Injection del DB Context
        public static IServiceCollection AddCustomizedDataStore(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<GameStoreDbContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("Conn")));
            return services;
        }

        //Injection del Repositorio
        public static IServiceCollection AddCustomizedRepository(this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            return services;
        }
    }
}
