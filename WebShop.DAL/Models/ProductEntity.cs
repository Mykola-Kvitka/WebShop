﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebShop.DAL.Models
{
    public class ProductEntity
    {
        [Key]
        public Guid ProductId { get; set; } = Guid.NewGuid();
        [MaxLength(128)]
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public double ProdPrice { get; set; }
        public List<ImageEntity> Img { get; set; }
        public DescriptionEntity Description { get; set; }

    }
}