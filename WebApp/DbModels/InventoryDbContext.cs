using Microsoft.EntityFrameworkCore;

namespace WebApp.DbModels
{
    public class InventoryDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public InventoryDbContext()
        {
        }

        public InventoryDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("inventory"));
        }

        public DbSet<Product> MyProperty { get; set; }
    }
}
