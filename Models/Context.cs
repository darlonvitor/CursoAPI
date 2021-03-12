using Microsoft.EntityFrameworkCore;
using System;

namespace CursoAPI.Models
{
    public class Context : DbContext
    {

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        // public Context(DbContextOptions<Context> options)
        // : base(options)
        // {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName:"cursoMvc");
        }
    }
}