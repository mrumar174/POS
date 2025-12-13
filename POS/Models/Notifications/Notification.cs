using POS.Entities.Customers;
using POS.Entities.User;
using System.ComponentModel.DataAnnotations;

namespace POS.Entities.Notifications
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }

        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int? UserId { get; set; }
        public Users User { get; set; }

        [Required, MaxLength(500)]
        public string Message { get; set; }
        [MaxLength(50)]
        public string SentVia { get; set; } // SMS, WhatsApp, Email
        public DateTime SentAt { get; set; } = DateTime.Now;
    }
}
