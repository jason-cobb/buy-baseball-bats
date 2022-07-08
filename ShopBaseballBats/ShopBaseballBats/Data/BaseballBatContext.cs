using Microsoft.EntityFrameworkCore;
using ShopBaseballBats.Models;


namespace ShopBaseballBats.Data
{
    public class BaseballBatContext : DbContext
    {
        public DbSet<BaseballBats>? BaseballBats { get; set; }
        public DbSet<BatBrand>? BatBrands { get; set; }

        public DbSet<Customer>? Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=ShopBaseballBatsData2");
           
        }
    }
}
