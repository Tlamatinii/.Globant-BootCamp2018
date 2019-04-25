using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LandingFinal.Patterns;

namespace LandingFinal.Models
{
    public class CarRental : Product
    {
        [StringLength(20)]
        [Display(Name = "Car Model")]
        public string CarModel { get; set; }
        public CarRental() { }

        public CarRental(String carModel, int category, float price) : base(price)
        {
            this.Price = price;
            this.Description = "Car";
            this.CarModel = carModel;
            this.Category = category;
            this.Type = ProductEnum.CarRental;
        }
    }
}