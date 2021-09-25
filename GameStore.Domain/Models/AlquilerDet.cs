using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Models
{
    [Table("Alquiler_Dets")]
    public class AlquilerDet : IAuditEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("AlquilerDetId")]
        public int AlquilerDetId { get; set; }
        public int Cantidad { get; set; }
        public int AlquilerId { get; set; }
        public int JuegoId { get; set; }
        public double Valor { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        [StringLength(50)]
        [Column(TypeName = "VARCHAR(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci")]
        public string CreatedBy { get; set; }

        //public Foreign Keys
        public virtual Alquiler Alquiler { get; set; }
        public virtual Juego Juego { get; set; }
    }
}
