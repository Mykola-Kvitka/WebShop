using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.DAL.Models
{
    public class CompletedOrderDetail
    {
        public int Id { get; set; }
        public int CompleteOrderId { get; set; }
        public int ProductId { get; set; }
        public int Kilkist { get; set; }
        public decimal price { get; set; }
        [MaxLength(64)]
        public string productName { get; set; }

    }
}
