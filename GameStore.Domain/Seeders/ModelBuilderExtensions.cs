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
            Random gen = new Random();
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;

            #region Estado
            modelBuilder.Entity<Estado>().HasData(
               new Estado
               {
                   Id = 1,
                   Nombre = "Activo",
                   CreatedAt = DateTime.Now,
                   CreatedBy = "JDLB"
               },
               new Estado
               {
                   Id = 2,
                   Nombre = "Inactivo",
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
                   CreatedAt = DateTime.Now,
                   CreatedBy = "JDLB"
               },
               new Estado
               {
                   Id = 5,
                   Nombre = "Error",
                   CreatedAt = DateTime.Now,
                   CreatedBy = "JDLB"
               }
            );
            #endregion

            #region Protagonista
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
            #endregion

            #region Marca
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
            #endregion

            #region Plataforma
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
            #endregion

            #region Cliente
            int id = 1;
            var faker = new Bogus.Faker<Cliente>()
                    .RuleFor(x => x.Id, f => id++)
                    .RuleFor(x => x.Nombre, f => f.Person.FirstName)
                    .RuleFor(x => x.Apellido, f => f.Person.LastName)
                    .RuleFor(x => x.NombreCompleto, f => f.Person.FullName)
                    .RuleFor(x => x.Email, f => f.Person.Email)
                    .RuleFor(x => x.Telefono, f => f.Phone.PhoneNumber())
                    .RuleFor(x => x.Nacimiento, f => f.Person.DateOfBirth)
                    .RuleFor(x => x.Nit, f => f.Random.Number(100000000, 999999999).ToString())
                    .RuleFor(x => x.CreatedAt, DateTime.Now)
                    .RuleFor(x => x.CreatedBy, "JDLB");
            
            foreach (var p in faker.Generate(50))
                modelBuilder.Entity<Cliente>().HasData(p);
            #endregion
            

            modelBuilder.Entity<Alquiler>().HasData(
                new Alquiler
                {
                    Id = 1,
                    Fecha_Reservacion = DateTime.Now.AddDays(-100),
                    Fecha_Devolucion = DateTime.Now.AddDays(-40),
                    Id_Estado = 3,
                    Id_Cliente = 1,
                    Valor_Total = 75000,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Alquiler
                {
                    Id = 2,
                    Fecha_Reservacion = DateTime.Now.AddDays(-2),
                    Fecha_Devolucion = DateTime.Now.AddDays(58),
                    Id_Estado = 4,
                    Id_Cliente = 2,
                    Valor_Total = 50000,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Alquiler
                {
                    Id = 3,
                    Fecha_Reservacion = DateTime.Now,
                    Fecha_Devolucion = DateTime.Now.AddDays(60),
                    Id_Estado = 4,
                    Id_Cliente = 3,
                    Valor_Total = 25000,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Alquiler
                {
                    Id = 4,
                    Fecha_Reservacion = DateTime.Now.AddDays(-65),
                    Fecha_Devolucion = DateTime.Now.AddDays(-5),
                    Id_Estado = 3,
                    Id_Cliente = 3,
                    Valor_Total = 100000,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Alquiler
                {
                    Id = 5,
                    Fecha_Reservacion = DateTime.Now.AddDays(-7),
                    Fecha_Devolucion = DateTime.Now.AddDays(53),
                    Id_Estado = 4,
                    Id_Cliente = 4,
                    Valor_Total = 75000,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Alquiler
                {
                    Id = 6,
                    Fecha_Reservacion = DateTime.Now,
                    Fecha_Devolucion = DateTime.Now.AddDays(60),
                    Id_Estado = 5,
                    Id_Cliente = 5,
                    Valor_Total = 25000,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Alquiler
                {
                    Id = 7,
                    Fecha_Reservacion = DateTime.Now.AddDays(-72),
                    Fecha_Devolucion = DateTime.Now.AddDays(-12),
                    Id_Estado = 3,
                    Id_Cliente = 4,
                    Valor_Total = 50000,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Alquiler
                {
                    Id = 8,
                    Fecha_Reservacion = DateTime.Now.AddDays(-83),
                    Fecha_Devolucion = DateTime.Now.AddDays(-23),
                    Id_Estado = 3,
                    Id_Cliente = 2,
                    Valor_Total = 25000,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Alquiler
                {
                    Id = 9,
                    Fecha_Reservacion = DateTime.Now,
                    Fecha_Devolucion = DateTime.Now.AddDays(60),
                    Id_Estado = 5,
                    Id_Cliente = 2,
                    Valor_Total = 125000,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Alquiler
                {
                    Id = 10,
                    Fecha_Reservacion = DateTime.Now.AddDays(-1),
                    Fecha_Devolucion = DateTime.Now.AddDays(59),
                    Id_Estado = 4,
                    Id_Cliente = 1,
                    Valor_Total = 50000,
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
                    Id_Marca = 3,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 4,
                    Nombre = "Tim Schafer",
                    Id_Marca = 4,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 5,
                    Nombre = "Ken Levine",
                    Id_Marca = 5,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 6,
                    Nombre = "Fumito Ueda",
                    Id_Marca = 6,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 7,
                    Nombre = "Yves Guillemot",
                    Id_Marca = 7,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 8,
                    Nombre = "Gabe Newell",
                    Id_Marca = 8,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 9,
                    Nombre = "Tom Howard",
                    Id_Marca = 9,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 10,
                    Nombre = "Yoko Taro",
                    Id_Marca = 3,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 11,
                    Nombre = "Shigeru Miyamoto",
                    Id_Marca = 2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 12,
                    Nombre = "Amy Hennig",
                    Id_Marca = 5,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 13,
                    Nombre = "Michel Ancel",
                    Id_Marca = 6,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 14,
                    Nombre = "Goichi Suda",
                    Id_Marca = 6,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 15,
                    Nombre = "Warren Spector",
                    Id_Marca = 7,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 16,
                    Nombre = "John Romero",
                    Id_Marca = 1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 17,
                    Nombre = "Yuji Horii",
                    Id_Marca = 2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 18,
                    Nombre = "Yuji Naka",
                    Id_Marca = 3,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 19,
                    Nombre = "Sid Meier",
                    Id_Marca = 7,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 20,
                    Nombre = "John Carmack",
                    Id_Marca = 9,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 21,
                    Nombre = "Keiji Inafune",
                    Id_Marca = 3,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Director
                {
                    Id = 22,
                    Nombre = "Hironobu Sakaguchi",
                    Id_Marca = 6,
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
                    Lanzamiento = new DateTime(2001, 5, 13),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 2,
                    Nombre = "Assassins Creed Valhalla",
                    Id_Director = 2,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 3,
                    Nombre = "GTA III",
                    Id_Director = 3,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 4,
                    Nombre = "GTA Vice City",
                    Id_Director = 5,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 5,
                    Nombre = "GTA San Andreas",
                    Id_Director = 4,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 6,
                    Nombre = "GTA IV",
                    Id_Director = 14,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 7,
                    Nombre = "GTA V",
                    Id_Director = 2,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 8,
                    Nombre = "FIFA 17",
                    Id_Director = 22,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 9,
                    Nombre = "FIFA 18",
                    Id_Director = 20,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 10,
                    Nombre = "FIFA 19",
                    Id_Director = 16,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 11,
                    Nombre = "FIFA 20",
                    Id_Director = 19,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 12,
                    Nombre = "FIFA 21",
                    Id_Director = 18,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 13,
                    Nombre = "Minecraft",
                    Id_Director = 3,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 14,
                    Nombre = "Gears Of War",
                    Id_Director = 4,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 15,
                    Nombre = "Watch_Dogs",
                    Id_Director = 8,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 16,
                    Nombre = "Watch_Dogs 2",
                    Id_Director = 7,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 17,
                    Nombre = "The Witcher",
                    Id_Director = 7,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 18,
                    Nombre = "The Witcher 2",
                    Id_Director = 7,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 19,
                    Nombre = "The Witcher 3",
                    Id_Director = 6,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 20,
                    Nombre = "Pokemon",
                    Id_Director = 4,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 21,
                    Nombre = "Age Of Empires",
                    Id_Director = 11,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 22,
                    Nombre = "Age Of Empires II",
                    Id_Director = 12,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 23,
                    Nombre = "Age Of Empires III",
                    Id_Director = 12,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 24,
                    Nombre = "Age Of Empires IV",
                    Id_Director = 8,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 25,
                    Nombre = "Red Dead Redemption II",
                    Id_Director = 23,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 26,
                    Nombre = "DOOM",
                    Id_Director = 1,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 27,
                    Nombre = "Pong",
                    Id_Director = 2,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 28,
                    Nombre = "The Sims",
                    Id_Director = 10,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 29,
                    Nombre = "The Sims 2",
                    Id_Director = 12,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 30,
                    Nombre = "Halo",
                    Id_Director = 13,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 31,
                    Nombre = "Angry Birds",
                    Id_Director = 15,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 32,
                    Nombre = "Plants vs Zombies",
                    Id_Director = 17,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 33,
                    Nombre = "Battlefield 3",
                    Id_Director = 2,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 34,
                    Nombre = "Fligth Simulation",
                    Id_Director = 6,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 35,
                    Nombre = "Chivarly II",
                    Id_Director = 9,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 36,
                    Nombre = "Pureya",
                    Id_Director = 11,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 37,
                    Nombre = "Rust",
                    Id_Director = 17,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 38,
                    Nombre = "Mass Effect: Legendary Edition",
                    Id_Director = 21,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 39,
                    Nombre = "Cyberpunk 2077",
                    Id_Director = 21,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 40,
                    Nombre = "The Last of Us 2",
                    Id_Director = 18,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 41,
                    Nombre = "Overwatch",
                    Id_Director = 23,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 42,
                    Nombre = "NBA 2K21",
                    Id_Director = 10,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 43,
                    Nombre = "Fortnite",
                    Id_Director = 23,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 44,
                    Nombre = "Star Wars: Squadrons",
                    Id_Director = 1,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 45,
                    Nombre = "Resident Evil 8: Village",
                    Id_Director = 2,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 46,
                    Nombre = "Heroes of the Storm",
                    Id_Director = 8,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 47,
                    Nombre = "Battefield 4",
                    Id_Director = 16,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 48,
                    Nombre = "Battlefield 2042",
                    Id_Director = 13,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 49,
                    Nombre = "florence",
                    Id_Director = 12,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
                },
                new Juego
                {
                    Id = 50,
                    Nombre = "portal",
                    Id_Director = 17,
                    Lanzamiento = start.AddDays(gen.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "JDLB"
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
