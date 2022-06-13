using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ShopBaseballBats.Models
{
    public class BaseballBats
    {
        public int Id { get; set; }
        public int BatId { get; set; }
        public BatModel[] BatModels { get; set; }
        public string DescriptionHtml { get; set; }
        public string BatBrand { get; set; }
        public bool Favorite { get; set; }
    }
}
