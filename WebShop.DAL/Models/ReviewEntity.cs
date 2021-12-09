using System;
using System.ComponentModel.DataAnnotations;

namespace WebShop.DAL.Models
{
    public class ReviewEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
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
