using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ShopBaseballBats.Models
{
    public class BatBrand
    {
        [Key]
        public int Id { get; set; }
        //[Display(Name = "Bat Brand")]
        //public BatBrand[]? BatBrands = new BatBrand[]
        //{
        //    new BatBrand()
        //    {
        //        Id = 1,
        //        BrandName = "Louisville Slugger",
        //       DescriptionHtml = "<p>Swing for the fences.</p>",
        //        ModelNames = new ModelName[]
        //        {
        //                new ModelName() {ModelNames = "Meta" },
        //                new ModelName() {ModelNames = "LXT"},
        //                new ModelName() {ModelNames = "Xeno"},
        //        }
        //    },
        //    new BatBrand()
        //    {
        //        Id = 2,
        //        BrandName = "Easton",
        //       // DescriptionHtml = "<p>Swing for the fences.</p>",
        //        ModelNames = new ModelName[]
        //        {
        //                new ModelName() {ModelNames = "Ghost" },
        //                new ModelName() {ModelNames = "Fire Fly"},
                       
        //        }
        //    },
        //    new BatBrand()
        //    {
        //        Id = 3,
        //        BrandName = "Rawlings",
        //       // DescriptionHtml = "<p>Swing for the fences.</p>",
        //        ModelNames = new ModelName[]
        //        {
        //                new ModelName() {ModelNames = "Mantra" },
                        
        //        }
        //    }
        //};
        



       

        public int Length { get; set; }
            //28, 29, 30, 31, 32
        public int Weight { get; set; }
        //-10, -11, -9


        public string DisplayText
        {
            get { return BrandName + "Shop Your Favorite Bats!"; }
        }
        public double Price { get; set; }
        public string? BrandName { get; private set; }
        public string ModelNames { get; set; }
        public string? DescriptionHtml { get; private set; }
        public bool Cart { get; set; }
        /*
        public string CoverImageFileName
        {
            get
            {
                return "lxt22.jpg"; //BatModels.Replace(" ", "-").ToLower() + "-" + BatModel.Length+ ".jpg";
            }
            //~/Images/meta22.jpg";
        }*/
        // public List<string> BatBrand { get => batBrand; set => batBrand=value; }
        //$400, $450
    }
}
