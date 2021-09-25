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
            var random = new Random();
            var start = new DateTime(1995, 1, 1);
            var startYear = new DateTime(2021, 1, 1);
            var range = (DateTime.Today - start).Days;
            var daysOfYear = (DateTime.Today - startYear).Days;
            var id = 1;
            var _CratedBy = "Juan Leon";

            #region Estado
            modelBuilder.Entity<Estado>().HasData(
               new Estado
               {
                   EstadoId = 1,
                   Nombre = "Activo",
                   CreatedAt = DateTime.Now,
                   CreatedBy = _CratedBy
               },
               new Estado
               {
                   EstadoId = 2,
                   Nombre = "Inactivo",
                   CreatedAt = DateTime.Now,
                   CreatedBy = _CratedBy
               },
               new Estado
               {
                   EstadoId = 3,
                   Nombre = "Devuelto",
                   CreatedAt = DateTime.Now,
                   CreatedBy = _CratedBy
               },
               new Estado
               {
                   EstadoId = 4,
                   Nombre = "Prestamo",
                   CreatedAt = DateTime.Now,
                   CreatedBy = _CratedBy
               },
               new Estado
               {
                   EstadoId = 5,
                   Nombre = "Error",
                   CreatedAt = DateTime.Now,
                   CreatedBy = _CratedBy
               }
            );
            #endregion

            #region Protagonista
            modelBuilder.Entity<Protagonista>().HasData(
                new Protagonista
                {
                    ProtagonistaId = 1,
                    Nombre = "Mario Bross",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 2,
                    Nombre = "Tommy Vercetti",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 3,
                    Nombre = "Altaïr Ibn-La'Ahad",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 4,
                    Nombre = "Natan Drake",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 5,
                    Nombre = "Crash Bandicoot",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 6,
                    Nombre = "Samus Aran",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 7,
                    Nombre = "John-117",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 8,
                    Nombre = "Aiden Perce",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 9,
                    Nombre = "Carl Jhonson",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 10,
                    Nombre = "Red",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 11,
                    Nombre = "Crazy Dave",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 12,
                    Nombre = "Spyro",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 13,
                    Nombre = "Marcus Fenix",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 14,
                    Nombre = "Vass",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 15,
                    Nombre = "Gordon Freeman",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 16,
                    Nombre = "Joel",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 17,
                    Nombre = "Jill Valentine",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 18,
                    Nombre = "Zelda",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 19,
                    Nombre = "Link",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 20,
                    Nombre = "Glados",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 21,
                    Nombre = "Meet Boy",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 22,
                    Nombre = "Geralt de Rivia",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 23,
                    Nombre = "Steve",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 24,
                    Nombre = "Ellie",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 25,
                    Nombre = "Faith",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 26,
                    Nombre = "Bayonetta",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 27,
                    Nombre = "Tracer",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 28,
                    Nombre = "Pacman",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 29,
                    Nombre = "Chris Redfield",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 30,
                    Nombre = "Leon S. Kennedy",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 31,
                    Nombre = "Agente 47",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 32,
                    Nombre = "Haytham Kenway",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Protagonista
                {
                    ProtagonistaId = 33,
                    Nombre = "Lara Croft",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                }
            );
            #endregion

            #region Marca
            modelBuilder.Entity<Marca>().HasData(
                new Marca
                {
                    MarcaId = 1,
                    Nombre = "Microsoft",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Marca
                {
                    MarcaId = 2,
                    Nombre = "Sony",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Marca
                {
                    MarcaId = 3,
                    Nombre = "EA",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Marca
                {
                    MarcaId = 4,
                    Nombre = "Ubisoft",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Marca
                {
                    MarcaId = 5,
                    Nombre = "Rovio",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Marca
                {
                    MarcaId = 6,
                    Nombre = "Activision",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Marca
                {
                    MarcaId = 7,
                    Nombre = "Nintendo",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Marca
                {
                    MarcaId = 8,
                    Nombre = "Rockstar",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Marca
                {
                    MarcaId = 9,
                    Nombre = "CD Project Red",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                }
            );
            #endregion

            #region Plataforma
            modelBuilder.Entity<Plataforma>().HasData(
                new Plataforma
                {
                    PlataformaId = 1,
                    Nombre = "PC",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Plataforma
                {
                    PlataformaId = 2,
                    Nombre = "Xbox",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Plataforma
                {
                    PlataformaId = 3,
                    Nombre = "Xbox 360",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Plataforma
                {
                    PlataformaId = 4,
                    Nombre = "Xbox ONE",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Plataforma
                {
                    PlataformaId = 5,
                    Nombre = "Xbox X",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Plataforma
                {
                    PlataformaId = 6,
                    Nombre = "PSP Vita",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Plataforma
                {
                    PlataformaId = 7,
                    Nombre = "PlayStation",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Plataforma
                {
                    PlataformaId = 8,
                    Nombre = "PlayStation 2",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Plataforma
                {
                    PlataformaId = 9,
                    Nombre = "PlayStation 3",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Plataforma
                {
                    PlataformaId = 10,
                    Nombre = "PlayStation 4",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Plataforma
                {
                    PlataformaId = 11,
                    Nombre = "PlayStation 5",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Plataforma
                {
                    PlataformaId = 12,
                    Nombre = "Nintendo 64",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Plataforma
                {
                    PlataformaId = 13,
                    Nombre = "Nintendo DS",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Plataforma
                {
                    PlataformaId = 14,
                    Nombre = "Nintendo Switch",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Plataforma
                {
                    PlataformaId = 15,
                    Nombre = "Android",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Plataforma
                {
                    PlataformaId = 16,
                    Nombre = "IOS",
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                }
            );
            #endregion

            #region Cliente
            var fakerCliente = new Bogus.Faker<Cliente>()
                    .RuleFor(x => x.ClienteId, f => id++)
                    .RuleFor(x => x.Nombre, f => f.Person.FirstName)
                    .RuleFor(x => x.Apellido, f => f.Person.LastName)
                    .RuleFor(x => x.NombreCompleto, f => f.Person.FullName)
                    .RuleFor(x => x.Email, f => f.Person.Email)
                    .RuleFor(x => x.Telefono, f => f.Phone.PhoneNumber())
                    .RuleFor(x => x.Nacimiento, f => f.Person.DateOfBirth)
                    .RuleFor(x => x.Nit, f => f.Random.Number(100000000, 999999999).ToString())
                    .RuleFor(x => x.CreatedAt, DateTime.Now)
                    .RuleFor(x => x.CreatedBy, _CratedBy);

            foreach (var p in fakerCliente.Generate(50))
                modelBuilder.Entity<Cliente>().HasData(p);
            #endregion

            #region Alquiler
            id = 1;
            var fakerAlquiler = new Bogus.Faker<Alquiler>()
                .RuleFor(x => x.AlquilerId, f => id++)
                .RuleFor(x => x.ClienteId, f => random.Next(1,50))
                .RuleFor(x => x.Valor_Total, f => f.Random.Number(25000, 150000))
                .RuleFor(x => x.CreatedAt, DateTime.Now)
                .RuleFor(x => x.CreatedBy, _CratedBy);

            foreach (var a in fakerAlquiler.Generate(100))
            {
                var dias = random.Next(1, 90);
                var _r = startYear.AddDays(random.Next(daysOfYear));
                var _d = _r.AddDays(dias);

                a.Fecha_Reservacion = _r;
                a.Fecha_Devolucion = _d;
                a.EstadoId = random.Next(100) <= 50 ? 4 : 3;

                modelBuilder.Entity<Alquiler>().HasData(a);
            }
            #endregion

            #region Director
            modelBuilder.Entity<Director>().HasData(
                new Director
                {
                    DirectorId = 1,
                    Nombre = "Hideo Kojima",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 2,
                    Nombre = "Will Wriths",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 3,
                    Nombre = "Hidetaka Miyazaki",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 4,
                    Nombre = "Tim Schafer",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 5,
                    Nombre = "Ken Levine",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 6,
                    Nombre = "Fumito Ueda",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 7,
                    Nombre = "Yves Guillemot",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 8,
                    Nombre = "Gabe Newell",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 9,
                    Nombre = "Tom Howard",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 10,
                    Nombre = "Yoko Taro",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 11,
                    Nombre = "Shigeru Miyamoto",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 12,
                    Nombre = "Amy Hennig",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 13,
                    Nombre = "Michel Ancel",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 14,
                    Nombre = "Goichi Suda",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 15,
                    Nombre = "Warren Spector",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 16,
                    Nombre = "John Romero",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 17,
                    Nombre = "Yuji Horii",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 18,
                    Nombre = "Yuji Naka",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 19,
                    Nombre = "Sid Meier",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 20,
                    Nombre = "John Carmack",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 21,
                    Nombre = "Keiji Inafune",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Director
                {
                    DirectorId = 22,
                    Nombre = "Hironobu Sakaguchi",
                    MarcaId = random.Next(1,9),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                }
            );
            #endregion

            #region Juego
            modelBuilder.Entity<Juego>().HasData(
                new Juego
                {
                    JuegoId = 1,
                    Nombre = "Assassins Creed I",
                    DirectorId = random.Next(1,22),
                    Precio = random.Next(15000,25000),
                    Stock = random.Next(2,15),
                    Lanzamiento = new DateTime(2001, 5, 13),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 2,
                    Nombre = "Assassins Creed Valhalla",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 3,
                    Nombre = "GTA III",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 4,
                    Nombre = "GTA Vice City",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 5,
                    Nombre = "GTA San Andreas",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 6,
                    Nombre = "GTA IV",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 7,
                    Nombre = "GTA V",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 8,
                    Nombre = "FIFA 17",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 9,
                    Nombre = "FIFA 18",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 10,
                    Nombre = "FIFA 19",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 11,
                    Nombre = "FIFA 20",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 12,
                    Nombre = "FIFA 21",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 13,
                    Nombre = "Minecraft",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 14,
                    Nombre = "Gears Of War",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 15,
                    Nombre = "Watch_Dogs",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 16,
                    Nombre = "Watch_Dogs 2",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 17,
                    Nombre = "The Witcher",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 18,
                    Nombre = "The Witcher 2",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 19,
                    Nombre = "The Witcher 3",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 20,
                    Nombre = "Pokemon",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 21,
                    Nombre = "Age Of Empires",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 22,
                    Nombre = "Age Of Empires II",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 23,
                    Nombre = "Age Of Empires III",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 24,
                    Nombre = "Age Of Empires IV",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 25,
                    Nombre = "Red Dead Redemption II",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 26,
                    Nombre = "DOOM",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 27,
                    Nombre = "Pong",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 28,
                    Nombre = "The Sims",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 29,
                    Nombre = "The Sims 2",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 30,
                    Nombre = "Halo",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 31,
                    Nombre = "Angry Birds",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 32,
                    Nombre = "Plants vs Zombies",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 33,
                    Nombre = "Battlefield 3",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 34,
                    Nombre = "Fligth Simulation",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 35,
                    Nombre = "Chivarly II",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 36,
                    Nombre = "Pureya",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 37,
                    Nombre = "Rust",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 38,
                    Nombre = "Mass Effect: Legendary Edition",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 39,
                    Nombre = "Cyberpunk 2077",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 40,
                    Nombre = "The Last of Us 2",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 41,
                    Nombre = "Overwatch",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 42,
                    Nombre = "NBA 2K21",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 43,
                    Nombre = "Fortnite",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 44,
                    Nombre = "Star Wars: Squadrons",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 45,
                    Nombre = "Resident Evil 8: Village",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 46,
                    Nombre = "Heroes of the Storm",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 47,
                    Nombre = "Battefield 4",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 48,
                    Nombre = "Battlefield 2042",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 49,
                    Nombre = "florence",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                },
                new Juego
                {
                    JuegoId = 50,
                    Nombre = "portal",
                    DirectorId = random.Next(1, 22),
                    Precio = random.Next(15000, 25000),
                    Stock = random.Next(2, 15),
                    Lanzamiento = start.AddDays(random.Next(range)),
                    CreatedAt = DateTime.Now,
                    CreatedBy = _CratedBy
                }
            );
            #endregion

            #region Plataforma_Juego
            id = 1;
            var fakerPlataformaJuego = new Bogus.Faker<PlataformaJuego>()
                .RuleFor(x => x.PlataformaJuegoId, f => id++)
                .RuleFor(x => x.JuegoId, f => random.Next(1,50))
                .RuleFor(x => x.PlataformaId, f => random.Next(1,16))
                .RuleFor(x => x.CreatedAt, DateTime.Now)
                .RuleFor(x => x.CreatedBy, _CratedBy);

            foreach (var pj in fakerPlataformaJuego.Generate(100))
                modelBuilder.Entity<PlataformaJuego>().HasData(pj);
            #endregion

            #region Protagonista_Juego
            id = 1;
            var fakerProtagonistaJuego = new Bogus.Faker<ProtagonistaJuego>()
                .RuleFor(x => x.ProtagonistaJuegoId, f => id++)
                .RuleFor(x => x.JuegoId, f => random.Next(1,50))
                .RuleFor(x => x.ProtagonistaId, f => random.Next(1,33))
                .RuleFor(x => x.CreatedAt, DateTime.Now)
                .RuleFor(x => x.CreatedBy, _CratedBy);

            foreach (var pj in fakerProtagonistaJuego.Generate(200))
                modelBuilder.Entity<ProtagonistaJuego>().HasData(pj);
            #endregion

            #region Alquler_Det
            id = 1;
            var fakerAlquilerDet = new Bogus.Faker<AlquilerDet>()
                .RuleFor(x => x.AlquilerDetId, f => id++)
                .RuleFor(x => x.AlquilerId, f => random.Next(1,100))
                .RuleFor(x => x.JuegoId, f => random.Next(1,50))
                .RuleFor(x => x.Cantidad, f => random.Next(1,10))
                .RuleFor(x => x.Cantidad, f => f.Random.Number(25000, 150000))
                .RuleFor(x => x.CreatedAt, DateTime.Now)
                .RuleFor(x => x.CreatedBy, _CratedBy);

            foreach (var ad in fakerAlquilerDet.Generate(300))
                modelBuilder.Entity<AlquilerDet>().HasData(ad);
            #endregion
        }

    }
}
