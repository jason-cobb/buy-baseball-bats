using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Web;


namespace ShopBaseballBats.Models
{
    public class BaseballBats
    {

        [Key]
        public int Id { get; set; }
       public int ModelYear { get; set; }
        public List<BatBrand> BatBrands { get; set; }


      

        //series-title-issuenumber.jpg
        //batmodel-year.jpg


    }
}
