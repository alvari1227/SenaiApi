using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Entidades;

namespace WebApplication1.Contexto
{
    public class SenaiContext : DbContext
    {
        public DbSet<Escola> Escola { get; set; }

        public DbSet<Endereço> Endereço { get; set; }

        public DbSet<Professor> Professor { get; set; }

        public DbSet<Classe> Classe { get; set; }

        public DbSet<Aluno> Aluno { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=Senai;User Id=postgres;Password=root;");
        }



    }
}
