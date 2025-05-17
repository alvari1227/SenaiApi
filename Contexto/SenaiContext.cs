using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Entidades;

namespace WebApplication1.Contexto
{
    public class SenaiContext : DbContext
    {
        public DbSet<Escola> Escola { get; set; }

        public DbSet<Escola> Endereço { get; set; }

        public DbSet<Escola> Professor { get; set; }

        public DbSet<Escola> Classe { get; set; }

        public DbSet<Escola> Aluno { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=Senai;User Id=postgres;Password=root;");
        }



    }
}
