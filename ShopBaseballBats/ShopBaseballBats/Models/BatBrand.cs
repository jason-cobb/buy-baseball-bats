using System.ComponentModel.DataAnnotations;

namespace ShopBaseballBats.Models
{
    public class BatBrand
    {
        [Key]
        public int Id { get; set; }
        public string? ModelName { get; set; }
        // LS, Easton, Rawlings

        public int Length { get; set; }
            //28, 29, 30, 31, 32
        public int Weight { get; set; }
            //-10, -11, -9
        public double Price { get; set; }
        //$400, $450
    }
}
