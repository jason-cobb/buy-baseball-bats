using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace ShopBaseballBats.Models
{
    public class BatBrand
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Bat Brand")]
        private List<BatBrand> batBrand = new List<BatBrand>
        {
            new BatBrand { BrandName = "Louisville Slugger" },
            new BatBrand { BrandName = "Easton" },
            new BatBrand {BrandName = "Rawlings"}
        };



        public string? ModelName { get; set; }
        // LS, Easton, Rawlings

        public int Length { get; set; }
            //28, 29, 30, 31, 32
        public int Weight { get; set; }
            //-10, -11, -9
        public double Price { get; set; }
        public string BrandName { get; private set; }
        // public List<string> BatBrand { get => batBrand; set => batBrand=value; }
        //$400, $450
    }
}
