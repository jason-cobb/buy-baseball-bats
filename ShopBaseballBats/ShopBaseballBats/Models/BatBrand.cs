using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ShopBaseballBats.Models
{
    [Display(Name = "Bat Brand")]
    public class BatBrand
    {
        [Key]
        public int Id { get; set; }
        public int Length { get; set; }
            //28, 29, 30, 31, 32
        public int? Weight { get; set; }
        //-10, -11, -12, -9
        public double? Price { get; set; }
        // 325, 399, 449
        [Display(Name = "Brand Name")]
        public string? BrandName { get; set; }
        // Louisville Slugger, Easton, Rawlings
        [Display(Name = "Bat Models")]
        public string? ModelNames { get; set; }
        //Louisville Slugger Meta, LXT and Xeno - Easton Ghost and Fire Fly, and Rawlings Mantra
        public string? DescriptionHtml { get; private set; }
        public bool? Cart { get; set; }
        /*
         * original repository
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
        /*public string DisplayText
        {
            get { return BrandName + "Shop Your Favorite Bats!"; }
        }*/
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
    }
}
