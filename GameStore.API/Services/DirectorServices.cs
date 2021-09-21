using GameStore.API.Interfaces;
using GameStore.Domain.Models;
using GameStore.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.API.Services
{
    public class DirectorServices : BaseRepository<Director>, IDirectorServices
    {
        public DirectorServices(IRepository<Director> repository) : base(repository)
        {

        }
    }
}
