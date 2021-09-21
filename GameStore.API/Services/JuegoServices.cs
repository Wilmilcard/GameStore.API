using GameStore.API.Interfaces;
using GameStore.Domain.Models;
using GameStore.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.API.Services
{
    public class JuegoServices : BaseRepository<Juego>, IJuegoServices
    {
        public JuegoServices(IRepository<Juego> repository) : base(repository)
        {

        }
    }
}
