using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Web;


namespace ShopBaseballBats.Models
{
    public class BaseballBats
    {   
               //BatBrand as a class or interface for LS, Easton, Rawlings etc.
            public string BatBrand { get; set; }
            public int Id { get; set; }
            public int BatId { get; set; }
            public BatModel[] BatModels { get; set; }
            public string DescriptionHtml { get; set; }

            public bool Favorite { get; set; }

            public string DisplayText
            {
                get { return BatModels + DescriptionHtml; }
            }
            //series-title-issuenumber.jpg
            //batmodel-year.jpg
            public string CoverImageFileName
            {
                get
                {
                return "file.jpg"; //BatModels.Replace(" ", "-").ToLower() + "-" + BatModel.Length+ ".jpg";
                }
            }
        
        
    }
}
