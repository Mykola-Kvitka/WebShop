using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebShop.DAL.Models
{
    public class CategoryEntity
    {
        [Key]
        public Guid NameId { get; set; } = Guid.NewGuid();
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(200)]
        public string Img { get; set; }
        public List<ProductEntity> Product { get; set; }
    }
}
