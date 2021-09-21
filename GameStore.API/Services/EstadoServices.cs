using GameStore.API.Interfaces;
using GameStore.Domain.Models;
using GameStore.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.API.Services
{
    public class EstadoServices : BaseRepository<Estado>, IEstadoServices
    {
        public EstadoServices(IRepository<Estado> repository) : base(repository)
        {

        }
    }
}
