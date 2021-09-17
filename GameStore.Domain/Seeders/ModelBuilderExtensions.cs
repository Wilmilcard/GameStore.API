using GameStore.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Seeders
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estado>().HasData(
               new Estado
               {
                   Nombre = "Activo",
                   CreatedAt = DateTime.Now,
                   CreatedBy = "JDLB"
               },
               new Estado
               {
                   Nombre = "Inactivo",
                   CreatedAt = DateTime.Now,
                   CreatedBy = "JDLB"
               }
            );
        }
    }
}
