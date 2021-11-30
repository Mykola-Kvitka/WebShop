using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.DAL.Models
{
    public class Description
    {
        [Key]
        public int DescId { get; set; }
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
