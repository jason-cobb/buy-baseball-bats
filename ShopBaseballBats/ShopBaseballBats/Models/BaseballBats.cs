using System;
using System.IO;
using System.Collections.Generic;
//using System.Linq;
//using System.Web;


namespace ShopBaseballBats.Models
{
    public class BaseballBats
    {   
              
            public string ?BatBrand { get; set; }
            public int Id { get; set; }
            
            public BatModel[] ?BatModels { get; set; }
            public string ?DescriptionHtml { get; set; }

            public bool Favorite { get; set; }

            public string DisplayText
            {
                get { return BatBrand + "Shop Your Favorite Bats!"; }
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
