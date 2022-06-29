using Microsoft.EntityFrameworkCore;

namespace ShopBaseballBats.Models
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlServer(@"Data Source=test.db");
        }

        public DbSet<Customer>? Customers { get; set; }
    }
}
