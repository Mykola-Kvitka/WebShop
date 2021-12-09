using System;
using System.ComponentModel.DataAnnotations;

namespace WebShop.BL.Models
{
    public class CompletedOrder
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int CompleteOrderId { get; set; }
        [MaxLength(64)]
        public string FirstName { get; set; }
        [MaxLength(64)]
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        [MaxLength(64)]
        public string PhoneNumber { get; set; }
        [MaxLength(64)]
        public string Adresses { get; set; }
    }
}
