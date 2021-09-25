using GameStore.Domain.Models;
using GameStore.Domain.Seeders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.DB
{
    public class GameStoreDbContext : DbContext
    {
        public GameStoreDbContext(DbContextOptions<GameStoreDbContext> options) : base(options)
        {

        }

        public DbSet<Alquiler> Alquiler { get; set; }
        public DbSet<AlquilerDet> AlquilerDets { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Director> Director { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Juego> Juego { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Plataforma> Plataforma { get; set; }
        public DbSet<PlataformaJuego> PlataformaJuego { get; set; }
        public DbSet<Protagonista> Protagonista { get; set; }
        public DbSet<ProtagonistaJuego> ProtagonistaJuego { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
