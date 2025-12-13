using System.ComponentModel.DataAnnotations;

namespace POS.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required, MaxLength(100)]
        public string CategoryName { get; set; }
        // Navigation
        public ICollection<Product> Products { get; set; }
    }
}
