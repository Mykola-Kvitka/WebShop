using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.DAL.Models
{
    public class CompletedOrder
    {
        public int Id { get; set; }
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
