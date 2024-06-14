using CardapioWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CardapioWeb.Context
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options) { }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
