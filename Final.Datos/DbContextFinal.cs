using System;
using System.Collections.Generic;
using System.Text;
using Final.Datos.Mapping;
using Final.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Final.Datos
{
   public class DbContextFinal : DbContext
    {
        public DbContextFinal(DbContextOptions<DbContextFinal> options) : base(options)
        {

        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Visita> Visistas { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PersonaMap());
            modelBuilder.ApplyConfiguration(new VisitaMap());
            modelBuilder.ApplyConfiguration(new DepartamentoMap());
        }
    }
}
