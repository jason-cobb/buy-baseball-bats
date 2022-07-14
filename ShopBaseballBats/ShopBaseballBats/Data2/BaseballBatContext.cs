﻿using Microsoft.EntityFrameworkCore;
using ShopBaseballBats.Models;


namespace ShopBaseballBats.Data2
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BatBrand>().HasData(new BatBrand { Id = 1, BrandName = "Louisville Slugger", })

        }
    }
}
