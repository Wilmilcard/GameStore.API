using GameStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.API.HttpRequestModels
{
    public class AlquilerCreateUpdate
    {
        public int AlquilerId { get; set; }
        public int ClienteId { get; set; }
        public int EstadoId { get; set; }
        public DateTime? Fecha_Reservacion { get; set; }
        public DateTime? Fecha_Devolucion { get; set; }
        public double Valor_Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public List<AlquilerDet> Juegos { get; set; }
    }
}
