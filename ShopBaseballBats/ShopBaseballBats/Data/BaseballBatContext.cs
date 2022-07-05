using Microsoft.EntityFrameworkCore;
using ShopBaseballBats.Models;
using ShopBaseballBats.Data;

namespace ShopBaseballBats.Data
{
    public class BaseballBatContext : DbContext
    {
        public DbSet<BaseballBat>? BaseballBats { get; set; }
        public DbSet<BatModel>? BatModels { get; set; }

        public DbSet<Customer>? Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=ShopBaseballBatsData");
           
        }
    }
}
