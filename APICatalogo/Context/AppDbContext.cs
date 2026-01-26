using Microsoft.EntityFrameworkCore;
using APICatalogo.Models;

namespace APICatalogo.Context
{
    public class AppDbContext : DbContext   
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base (option)
        {
                
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }


    }
}
