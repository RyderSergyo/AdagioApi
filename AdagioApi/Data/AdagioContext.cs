using AdagioApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdagioApi.Data
{
    public class AdagioContext : DbContext
    {
        public AdagioContext(DbContextOptions<AdagioContext> options) : base(options) { }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>().ToTable("Alumno");
            modelBuilder.Entity<Clase>().ToTable("Clase");
            modelBuilder.Entity<Matricula>().ToTable("Matricula").HasKey(c => new { c.AlumnoId, c.ClaseId });
        }
    }
}
