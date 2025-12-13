using POS.Entities.Notifications;
using System.ComponentModel.DataAnnotations;

namespace POS.Entities.Customers
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required, MaxLength(100)]
        public string FullName { get; set; }
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        public int LoyaltyPoints { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Navigation
        public ICollection<Sale> Sales { get; set; }
        public ICollection<Notification> Notifications { get; set; }
    }
}
