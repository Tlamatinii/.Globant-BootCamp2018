using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using LandingFinal.Patterns;

namespace LandingFinal.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name ="Product Price")]
        public float Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        public int Category { get; set; }

        public ProductEnum Type { get; set; }

        

        public Product() { }

        protected Product(float price) 
        {
            Price = price;
        }

        public virtual ICollection<Package> Packages { get; set; }
    }
}