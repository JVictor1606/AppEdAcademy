using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdAcademy.Model.Bd
{
    public class EdDbContexts : DbContext
    {
        
        public EdDbContexts(DbContextOptions options) : base(options)
        {
        }

       public DbSet<Aluno> Alunos { get; set; }
       public DbSet<Professor> Professor { get; set; }
       public DbSet<Curso> Curso { get; set; }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connection = "Server=localhost\\SQLEXPRESS;Database=EdAcademy;Trusted_Connection=True;";
                optionsBuilder.UseSqlServer(connection);
            }
        }


        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Aluno>().HasKey(a => a.Id);

            mb.Entity<Aluno>().
                Property(a => a.Nome).
                IsRequired();

            mb.Entity<Aluno>().
                Property(a => a.DataNascimento);

            mb.Entity<Aluno>().
                Property(a => a.Nivel);

            mb.Entity<Aluno>().
                Property(a => a.Email).
                IsRequired();

            mb.Entity<Aluno>().
                Property(a => a.Formacao).
                IsRequired();

            mb.Entity<Professor>().HasKey(a => a.Id);

            mb.Entity<Professor>().
                Property(a => a.Nome).
                IsRequired();

            mb.Entity<Professor>().
                Property(a => a.Email).
                IsRequired();

            mb.Entity<Professor>().
                Property(a => a.Formacao).
                IsRequired();

            mb.Entity<Professor>().
                Property(a => a.DataNascimento);

            mb.Entity<Professor>().
                HasMany(a => a.Cursos)
                .WithOne(a => a.Professor)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);


            mb.Entity<Curso>().HasKey(a => a.Id);

            mb.Entity<Curso>().
                HasMany(a => a.Alunos)
                .WithOne(a => a.Curso)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
