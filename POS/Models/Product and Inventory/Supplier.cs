using POS.Entities.Orders;
using System.ComponentModel.DataAnnotations;

namespace POS.Entities
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        [Required, MaxLength(100)]
        public string SupplierName { get; set; }
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(200)]
        public string Address { get; set; }

        // Navigation
        public ICollection<Product> Products { get; set; }
        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
