using POS.Entities.Orders;
using System.ComponentModel.DataAnnotations;
using System.Net.ServerSentEvents;

namespace POS.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required, MaxLength(100)]
        public string ProductName { get; set; }
        [Required, MaxLength(50)]
        public string SKU { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // FK
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        // Navigation
        public Inventory Inventory { get; set; }
        public ICollection<SaleItem> SaleItems { get; set; }
        public ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
    }
}
