using GameStore.API.Interfaces;
using GameStore.Domain.Models;
using GameStore.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.API.Services
{
    public class PlataformaServices : BaseRepository<Plataforma>, IPlataformaServices
    {
        public PlataformaServices(IRepository<Plataforma> repository) : base(repository)
        {

        }
    }
}
