using System;
using System.ComponentModel.DataAnnotations;

namespace WebShop.BL.Models
{
    public class CompletedOrderDetail
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int CompleteOrderId { get; set; }
        public int ProductId { get; set; }
        public int Kilkist { get; set; }
        public decimal price { get; set; }
        [MaxLength(64)]
        public string productName { get; set; }

    }
}
