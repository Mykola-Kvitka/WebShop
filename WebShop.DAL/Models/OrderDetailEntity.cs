using System;
using System.ComponentModel.DataAnnotations;

namespace WebShop.DAL.Models
{
    public class OrderDetailEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal price { get; set; }
        public int Kilkist { get; set; }
        [MaxLength(64)]
        public string productName { get; set; }

    }
}
