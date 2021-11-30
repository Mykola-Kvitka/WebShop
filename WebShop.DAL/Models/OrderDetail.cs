using System;
using System.ComponentModel.DataAnnotations;


namespace WebShop.DAL.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal price { get; set; }
        public int Kilkist { get; set; }
        [MaxLength(64)]
        public string productName { get; set; }

    }
}
