using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Models
{
    [Table("Protagonista_Juego")]
    public class ProtagonistaJuego : IAuditEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("ProtagonistaJuegoId")]
        public int ProtagonistaJuegoId { get; set; }
        public int JuegoId { get; set; }
        public int ProtagonistaId { get; set; }
        

        //Auditory
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        [StringLength(50)]
        [Column(TypeName = "VARCHAR(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci")]
        public string CreatedBy { get; set; }


        //Public Foreign Key
        public virtual Juego Juego { get; set; }
        public virtual Protagonista Protagonista { get; set; }
    }
}
