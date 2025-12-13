using POS.Entities.Customers;
using POS.Entities.User;
using System.ComponentModel.DataAnnotations;
using System.Net.ServerSentEvents;
using POS.Entities.Delivery;

namespace POS.Entities
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }

        [Required]
        public int UserId { get; set; }
        public Users User { get; set; }

        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; } = 0;
        public decimal Tax { get; set; } = 0;
        [MaxLength(50)]
        public string PaymentMethod { get; set; } // Cash, JazzCash, Easypaisa
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation
        public ICollection<SaleItem> SaleItems { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public Deliveries Delivery { get; set; } // Optional one-to-one
    }
}
