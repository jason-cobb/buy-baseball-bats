using System.ComponentModel.DataAnnotations;

namespace ShopBaseballBats.Models
{
    public class BatModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }
        public double Price { get; set; }
    }
}
