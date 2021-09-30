using GameStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.API.HttpRequestModels
{
    public class JuegoCreateUpdate
    {
        public int JuegoId { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public DateTime? Lanzamiento { get; set; }
        public int DirectorId { get; set; }
        public int Stock { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public List<Plataforma> Plataformas { get; set; }
        public List<Protagonista> Protagonistas { get; set; }
    }
}
