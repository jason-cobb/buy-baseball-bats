using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Web;


namespace ShopBaseballBats.Models
{
    public class BaseballBat
    {
            [Key]
            
            public int Id { get; set; }
            //public string? BatBrand { get; set; }

            public List<BatBrand>? BatBrands { get; set; }
            public string ?DescriptionHtml { get; set; }

            public bool Favorite { get; set; }

            public string DisplayText
            {
                get { return BatBrands + "Shop Your Favorite Bats!"; }
            }
            //series-title-issuenumber.jpg
            //batmodel-year.jpg
            public string CoverImageFileName
            {
                get
                {
                    return "lxt22.jpg"; //BatModels.Replace(" ", "-").ToLower() + "-" + BatModel.Length+ ".jpg";
                }
                //~/Images/meta22.jpg";
            }
        
    }
}
