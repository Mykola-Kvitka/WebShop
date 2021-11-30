using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.DAL.Models
{
    public class Characteristic
    {
        public int id { get; set; }
        public int ProdId { get; set; }
        [Required]
        [MaxLength(64)]
        public string CharactName { get; set; }
        [Required]
        [MaxLength(200)]
        public string CharactText { get; set; }
    }
}
