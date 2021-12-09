using System;
using System.ComponentModel.DataAnnotations;

namespace WebShop.BL.Models
{
    public class Characteristic
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public int ProdId { get; set; }
        [Required]
        [MaxLength(64)]
        public string CharactName { get; set; }
        [Required]
        [MaxLength(200)]
        public string CharactText { get; set; }
    }
}
