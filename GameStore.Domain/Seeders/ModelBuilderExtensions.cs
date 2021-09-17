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
                },
                new Protagonista
                {
                    Id = 2,
                    Nombre = "Tommy Vercetti",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 3,
                    Nombre = "Altaïr Ibn-La'Ahad",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 4,
                    Nombre = "Natan Drake",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 5,
                    Nombre = "Crash Bandicoot",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 6,
                    Nombre = "Samus Aran",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 7,
                    Nombre = "John-117",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 8,
                    Nombre = "Aiden Perce",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 9,
                    Nombre = "Carl Jhonson",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 10,
                    Nombre = "Red",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 11,
                    Nombre = "Crazy Dave",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 12,
                    Nombre = "Spyro",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 13,
                    Nombre = "Marcus Fenix",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 14,
                    Nombre = "Vass",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 15,
                    Nombre = "Gordon Freeman",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 16,
                    Nombre = "Joel",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 17,
                    Nombre = "Jill Valentine",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 18,
                    Nombre = "Zelda",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 19,
                    Nombre = "Link",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id =20,
                    Nombre = "Glados",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 21,
                    Nombre = "Meet Boy",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 22,
                    Nombre = "Geralt de Rivia",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 23,
                    Nombre = "Steve",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 24,
                    Nombre = "Ellie",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 25,
                    Nombre = "Faith",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 26,
                    Nombre = "Bayonetta",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 27,
                    Nombre = "Tracer",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 28,
                    Nombre = "Pacman",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 29,
                    Nombre = "Chris Redfield",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 30,
                    Nombre = "Leon S. Kennedy",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 31,
                    Nombre = "Agente 47",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 32,
                    Nombre = "Haytham Kenway",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Protagonista
                {
                    Id = 33,
                    Nombre = "Lara Croft",
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
                },
                new Marca
                {
                    Id = 2,
                    Nombre = "Sony",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Marca
                {
                    Id = 3,
                    Nombre = "EA",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Marca
                {
                    Id = 4,
                    Nombre = "Ubisoft",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Marca
                {
                    Id = 5,
                    Nombre = "Rovio",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Marca
                {
                    Id = 6,
                    Nombre = "Activision",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Marca
                {
                    Id = 7,
                    Nombre = "Nintendo",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Marca
                {
                    Id = 8,
                    Nombre = "Rockstar",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Marca
                {
                    Id = 9,
                    Nombre = "CD Project Red",
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
                },
                new Plataforma
                {
                    Id = 2,
                    Nombre = "Xbox",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Plataforma
                {
                    Id = 3,
                    Nombre = "Xbox 360",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Plataforma
                {
                    Id = 4,
                    Nombre = "Xbox ONE",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Plataforma
                {
                    Id = 5,
                    Nombre = "Xbox X",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Plataforma
                {
                    Id = 6,
                    Nombre = "PSP Vita",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Plataforma
                {
                    Id = 7,
                    Nombre = "PlayStation",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Plataforma
                {
                    Id = 8,
                    Nombre = "PlayStation 2",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Plataforma
                {
                    Id = 9,
                    Nombre = "PlayStation 3",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Plataforma
                {
                    Id = 10,
                    Nombre = "PlayStation 4",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Plataforma
                {
                    Id = 11,
                    Nombre = "PlayStation 5",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Plataforma
                {
                    Id = 12,
                    Nombre = "Nintendo 64",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Plataforma
                {
                    Id = 13,
                    Nombre = "Nintendo DS",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Plataforma
                {
                    Id = 14,
                    Nombre = "Nintendo Switch",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Plataforma
                {
                    Id = 15,
                    Nombre = "Android",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Plataforma
                {
                    Id = 16,
                    Nombre = "IOS",
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
