using POS.Entities.User;
using System.ComponentModel.DataAnnotations;

namespace POS.Entities.Delivery
{
    public class Deliveries
    {
        [Key]
        public int DeliveryId { get; set; }

        [Required]
        public int SaleId { get; set; }
        public Sale Sale { get; set; }

        [Required]
        public int DeliveryStaffId { get; set; }
        public Users DeliveryStaff { get; set; }

        [MaxLength(50)]
        public string DeliveryStatus { get; set; } = "Pending"; // Pending, OutForDelivery, Delivered, Cancelled

        public DateTime ExpectedDeliveryTime { get; set; }
        public DateTime? ActualDeliveryTime { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
