using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lite
{
    public class ProdutoContext:DbContext
    {
        public DbSet<Produto> Produtos;
        public DbSet<Categoria> Categorias;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = produtos.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { Id = 1, Nome = "carne" },
                new Categoria { Id = 2, Nome = "limpeza"});
            modelBuilder.Entity<Produto>().HasData(
                new Produto { Id = 1, Nome = "Frango", CategoriaId = 1 },
                new Produto { Id = 2, Nome = "Detergente", CategoriaId = 2}
                );
        }
    }
}
