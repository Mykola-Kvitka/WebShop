using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebShop.DAL.Models
{
    public class Category
    {
        [Key]
        public int NameId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(200)]
        public string Img { get; set; }

        public List<Product> Product { get; set; }
    }
}
