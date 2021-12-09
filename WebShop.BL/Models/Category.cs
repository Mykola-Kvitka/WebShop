using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebShop.BL.Models
{
    public class Category
    {
        [Key]
        public Guid NameId { get; set; } = Guid.NewGuid();
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(200)]
        public string Img { get; set; }
        public IFormFile Image { get; set; }
        public List<Product> Product { get; set; }
    }
}
