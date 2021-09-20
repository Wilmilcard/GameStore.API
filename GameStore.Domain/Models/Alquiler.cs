using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Models
{
    [Table("Alquiler")]
    public class Alquiler : IAuditEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Estado { get; set; }
        public DateTime? Fecha_Reservacion { get; set; }
        public DateTime? Fecha_Devolucion { get; set; }
        public double Valor_Total { get; set; }


        //Auditory
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        [StringLength(50)]
        [Column(TypeName = "VARCHAR(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci")]
        public string CreatedBy { get; set; }

        
        //Public Foreign Key
        public virtual Cliente Cliente { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
