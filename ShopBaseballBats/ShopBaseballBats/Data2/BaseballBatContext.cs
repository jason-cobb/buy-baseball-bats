using Microsoft.EntityFrameworkCore;
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
            //optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=ShopBaseballBatsData2");
            optionsBuilder.UseSqlite("Data Source= {ShopBaseballBatsData2.db}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            var final = new List<BatBrand>();
            var lengths = new List<int>
            {
                28, 29, 30, 31, 32, 33
            };
            var price = new List<double>
            {
                325, 399, 449.00
            };
            var modelNames = new List<string>
            {
                "LXT", "Meta", "Xeno", 
                "Ghost", "Fire Fly",
                "Mantra"
            };
            
            
            var batBrands = new List<string>
            {
                 "Louisville Slugger",
                 "Easton",
                 "Rawlings"
            };
            var i = 0;
            foreach (var name in modelNames)
            foreach (var length in lengths)
                foreach (var batBrand in batBrands) 
                {
                        i++; var finalBat = new BatBrand
                        {
                            Id=i,
                            BrandName=batBrand,
                            Length=length,
                        };
                        if (batBrand=="Louisville Slugger" && (name == "LXT" || name== "Meta" || name== "Xeno"))
                        {
                            AddBatToFinal(final, name, finalBat);
                        }
                        else if(batBrand=="Easton" && (name == "Ghost" || name== "Fire Fly"))
                            AddBatToFinal(final, name, finalBat);
                        else if(batBrand=="Rawlings" &&(name == "Mantra"))
                            AddBatToFinal(final, name, finalBat);
                        
                }
            modelBuilder.Entity<BatBrand>().HasData(final);
            base.OnModelCreating(modelBuilder);
        }

        private static void AddBatToFinal(List<BatBrand> final, string name, BatBrand finalBat)
        {
            finalBat.ModelNames = name;
            final.Add(finalBat);
        }

        //batBrands.ForEach(b => DbContext.BrandNames.Add(b));
        //DbContext.SaveChanges();




        /*
        modelBuilder.Entity<BatBrand>()
           .HasMany(n => n.BrandName)
           .WithMany(m => m.ModelNames)
           .WithMany(l => l.Length)
           .WithMany(w => w.Weight)
           .WithMany(p => p.Price);
        */


    }
    }
