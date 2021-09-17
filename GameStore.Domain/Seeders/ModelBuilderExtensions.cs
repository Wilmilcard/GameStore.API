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
                   Id = 1,
                   Nombre = "Activo",
                   Cod = 'A',
                   CreatedAt = DateTime.Now,
                   CreatedBy = "JDLB"
               },
               new Estado
               {
                   Id = 2,
                   Nombre = "Inactivo",
                   Cod = 'I',
                   CreatedAt = DateTime.Now,
                   CreatedBy = "JDLB"
               },
               new Estado
               {
                   Id = 3,
                   Nombre = "Devuelto",
                   CreatedAt = DateTime.Now,
                   CreatedBy = "JDLB"
               },
               new Estado
               {
                   Id = 4,
                   Nombre = "Prestamo",
                   Cod = 'P',
                   CreatedAt = DateTime.Now,
                   CreatedBy = "JDLB"
               },
               new Estado
               {
                   Id = 5,
                   Nombre = "Error",
                   Cod = 'E',
                   CreatedAt = DateTime.Now,
                   CreatedBy = "JDLB"
               }
            );
            
            modelBuilder.Entity<Protagonista>().HasData(
                new Protagonista
                {
                    Id = 1,
                    Nombre = "Mario Bross",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                }
            );

            modelBuilder.Entity<Marca>().HasData(
                new Marca
                {
                    Id = 1,
                    Nombre = "Microsoft",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                }
            );

            modelBuilder.Entity<Plataforma>().HasData(
                new Plataforma
                {
                    Id = 1,
                    Nombre = "PC",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                }
            );

            modelBuilder.Entity<Cliente>().HasData(
                new Cliente
                {
                    Id = 1,
                    Nombre = "Jhon Stalker",
                    Apellido = "Mayer Ghal",
                    NombreCompleto = "Jhon Stalker Mayer Ghal",
                    Email = "jhon.m@nevergate.com.co",
                    Telefono = "000 00 00",
                    Nacimiento = DateTime.Now.AddYears(-24),
                    Nit = "000.000.000-0",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                }
            );

            modelBuilder.Entity<Alquiler>().HasData(
                new Alquiler
                {
                    Id = 1,
                    Fecha_Reservacion = DateTime.Now,
                    Fecha_Devolucion = DateTime.Now.AddDays(60),
                    Id_Estado = 1,
                    Id_Cliente = 1,
                    Valor_Total = 75000,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                }
            );

            modelBuilder.Entity<Director>().HasData(
                new Director
                {
                    Id = 1,
                    Nombre = "Hideo Kojima",
                    Id_Marca = 1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 2,
                    Nombre = "Will Wriths",
                    Id_Marca = 2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 3,
                    Nombre = "Hidetaka Miyazaki",
                    Id_Marca = 2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                }
            );

            modelBuilder.Entity<Juego>().HasData(
                new Juego
                {
                    Id = 1,
                    Nombre = "Assassins Creed I",
                    Id_Director = 1,
                    Lanzamiento = new DateTime(2001, 5, 13)
                }
            );

            modelBuilder.Entity<Plataforma_Juego>().HasData(
                new Plataforma_Juego
                {
                    Id = 1,
                    Id_Juego = 1,
                    Id_Plataforma = 2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                }
            );

            modelBuilder.Entity<Protagonista_Juego>().HasData(
                new Protagonista_Juego
                {
                    Id = 1,
                    Id_Juego = 1,
                    Id_Protagonista = 1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                }
            );

            modelBuilder.Entity<Alquiler_Det>().HasData(
                new Alquiler_Det
                {
                    Id = 1,
                    Id_Alquiler = 1,
                    Id_Juego = 1,
                    Cantidad = 5,
                    Valor = 5 * 15000,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                }
            );
        }
    }
}
