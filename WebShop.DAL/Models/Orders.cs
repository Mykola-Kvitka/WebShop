using System;
using System.ComponentModel.DataAnnotations;

namespace WebShop.DAL.Models
{
    public class Orders
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        [MaxLength(14)]
        public string PhoneNumber { get; set; }
    }
}
