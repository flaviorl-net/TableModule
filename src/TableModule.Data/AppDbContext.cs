using Microsoft.EntityFrameworkCore;
using TableModule.Data.Model;

namespace TableModule.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<EnderecoCliente> EnderecoCliente { get; set; }
    }
}
