using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Api5.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        [Range(0,999)]
        public double Weight { get; set; }
    }
}