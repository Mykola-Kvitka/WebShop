using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebShop.BL.Models
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; } = Guid.NewGuid();
        [MaxLength(128)]
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public double ProdPrice { get; set; }
        public List<Image> Img { get; set; }
        public List<IFormFile> Images { get; set; }
        public Description Description { get; set; }

    }
}
