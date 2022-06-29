using Microsoft.EntityFrameworkCore;

namespace ShopBaseballBats.Models
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
           
            options.UseSqlServer(@"Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog = ShopBaseballBatsData");
           // optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=ShopBaseballBatsData");

        }

        public DbSet<Customer>? Customers { get; set; }
    }
}
