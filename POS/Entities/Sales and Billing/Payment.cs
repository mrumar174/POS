using System.ComponentModel.DataAnnotations;

namespace POS.Entities
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        public int SaleId { get; set; }
        public Sale Sale { get; set; }

        [Required]
        public decimal AmountPaid { get; set; }
        [MaxLength(50)]
        public string PaymentMethod { get; set; }
        public DateTime PaidAt { get; set; } = DateTime.Now;
        public string TransactionId { get; set; }
    }
}
