using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.DAL.Models
{
    public class Review
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string ReviewerName { get; set; }
        [MaxLength(20)]
        public string ReviewerPhone { get; set; }
        [MaxLength(2000)]
        public string ReviewText { get; set; }
        public int ReviewRating { get; set; }
        public int ReviewProductId { get; set; }
    }
}
