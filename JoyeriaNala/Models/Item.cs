using System.ComponentModel.DataAnnotations;

namespace JoyeriaNala.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Materials { get; set; }
    }
}
