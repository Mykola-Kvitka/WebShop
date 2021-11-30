using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.DAL.Models
{
    public class Image
    {
        [Key]
        [MaxLength(256)]
        public string PathID { get; set; }
        public int ProductId { get; set; }
    }
}
