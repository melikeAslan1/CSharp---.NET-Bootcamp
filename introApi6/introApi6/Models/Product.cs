﻿using System.ComponentModel.DataAnnotations;

namespace introApi6.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMassage="Ad alanı boş geçilemez.")]
        public string Name { get; set; }
        public double? Price { get; set; }
        public int? Stock { get; set; }
        public string? Description { get; set; }
        public double? Discount { get; set; }
        public string? ImageUrl { get; set; }


    }
}
