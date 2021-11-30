using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebShop.DAL.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [MaxLength(128)]
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public double ProdPrice { get; set; }
        public List<Image> Img { get; set; }
        public Description Description { get; set; }

    }
}
