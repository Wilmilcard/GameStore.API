﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Models
{
    [Table("Cliente")]
    public class Cliente : IAuditEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("ClienteId")]
        public int ClienteId { get; set; }
        [StringLength(100)]
        [Column(TypeName = "VARCHAR(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci")]
        public string Nombre { get; set; }
        [StringLength(100)]
        [Column(TypeName = "VARCHAR(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci")]
        public string Apellido { get; set; }
        [StringLength(200)]
        [Column(TypeName = "VARCHAR(200) CHARACTER SET utf8 COLLATE utf8_unicode_ci")]
        public string NombreCompleto { get; set; }
        [Column("Telefono")]
        [StringLength(30)] 
        public string Telefono { get; set; }
        [Column("Nit")]
        [StringLength(30)]
        public string Nit { get; set; }
        [Column("Email")]
        [StringLength(50)]
        public string Email { get; set; }
        public DateTime? Nacimiento { get; set; }

        
        //Auditory
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        [StringLength(50)]
        [Column(TypeName = "VARCHAR(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci")]
        public string CreatedBy { get; set; }
    }
}
