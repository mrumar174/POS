using POS.Entities.Delivery;
using POS.Entities.Orders;
using System.ComponentModel.DataAnnotations;

namespace POS.Entities.User
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [Required, MaxLength(100)]
        public string FullName { get; set; }
        [Required, MaxLength(50)]
        public string Username { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [Required]
        public int RoleId { get; set; }
        public Role Role { get; set; }

        // Navigation
        public ICollection<Sale> Sales { get; set; }
        public ICollection<PurchaseOrder> CreatedPurchaseOrders { get; set; }
        public ICollection<Deliveries> Deliveries { get; set; }
    }
}
