using System;
using System.ComponentModel.DataAnnotations;

namespace WebShop.DAL.Models
{
    public class DescriptionEntity
    {
        [Key]
        public Guid DescId { get; set; } = Guid.NewGuid();
        [Required]
        [MaxLength(2000)]
        public string LongDiscription { get; set; }

        [MaxLength(2000)]
        public string materials { get; set; }

        [MaxLength(2000)]
        public int volume { get; set; }

        [MaxLength(2000)]
        public string features { get; set; }
    }
}
