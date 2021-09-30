using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Models
{
    [Table("Juego")]
    public class Juego : IAuditEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("JuegoId")]
        public int JuegoId { get; set; }
        [StringLength(80)]
        [Column(TypeName = "VARCHAR(80) CHARACTER SET utf8 COLLATE utf8_unicode_ci")]
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public DateTime? Lanzamiento { get; set; }
        public int DirectorId { get; set; }
        public int Stock { get; set; }
        
        
        //Auditory
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        [StringLength(50)]
        [Column(TypeName = "VARCHAR(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci")]
        public string CreatedBy { get; set; }


        //Listas de las relaciones
        public List<PlataformaJuego> PlataformaJuegos { get; set; }
        public List<ProtagonistaJuego> ProtagonistaJuegos { get; set; }


        //Public Foreign Key
        public virtual Director Director { get; set; }
    }
}
