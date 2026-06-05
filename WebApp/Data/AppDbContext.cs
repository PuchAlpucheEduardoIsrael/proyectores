using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Proyector> Proyectores { get; set; }

        public DbSet<Departamento> Departamentos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Departamento>()
                .ToTable("Departamentos")
                //.HasMany(e => e.Proyectores)
                //.WithOne(e => e.Departamento)
                //.HasForeignKey(e => e.DepartamentoId)
                //.IsRequired()
                .HasData(
                    new Departamento()
                    {
                        Id = 1,
                        Titulo = "Departamento de Sistemas y Computación"
                    },
                    new Departamento()
                    {
                        Id = 2,
                        Titulo = "Departamento de Ingeniería Industrial"
                    },
                    new Departamento()
                    {
                        Id = 3,
                        Titulo = "Departamento de Ciencias de la Tierra"
                    },
                    new Departamento()
                    {
                        Id = 4,
                        Titulo = "Departamento de Ciencias Economico-Administrativas"
                    },
                    new Departamento()
                    {
                        Id = 5,
                        Titulo = "Departamento de Metal-Mecanica"
                    },
                    new Departamento()
                    {
                        Id = 6,
                        Titulo = "Departamento de Quimica-Bioquimica"
                    }
                    ,
                    new Departamento()
                    {
                        Id = 7,
                        Titulo = "Departamento de Ciencias Basicas"
                    }
                    );
            modelBuilder.Entity<Proyector>()
                    .ToTable("Proyectores")
                    .HasOne(e => e.Departamento)
                    .WithMany(e => e.Proyectores)
                    .HasForeignKey(e => e.DepartamentoId) 
                    .IsRequired();
        }
    }
}
