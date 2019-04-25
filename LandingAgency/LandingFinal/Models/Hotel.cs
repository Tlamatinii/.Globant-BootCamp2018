using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using LandingFinal.Patterns;

namespace LandingFinal.Models
{
    public class Hotel : Product
    {
        [StringLength(50)]
        [Display(Name ="Hotel Name")]
        public string HotelName { get; set; }

        public Hotel() { }

        public Hotel(String hotelName, float price) : base(price)
        {
            this.HotelName = hotelName;
            this.Price = price;
            this.Description = "Hotel";
            this.Type = ProductEnum.Hotel;
        }
    }
}