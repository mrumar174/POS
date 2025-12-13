using POS.Entities.User;
using System.ComponentModel.DataAnnotations;

namespace POS.Entities.Orders
{
    public class PurchaseOrder
    {
        [Key]
        public int PurchaseOrderId { get; set; }

        [Required]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        [Required]
        public int CreatedByUserId { get; set; }
        public Users CreatedByUser { get; set; }

        public decimal TotalAmount { get; set; }
        [MaxLength(50)]
        public string Status { get; set; } = "Pending"; // Pending, Received, Cancelled
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Navigation
        public ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
    }
}
