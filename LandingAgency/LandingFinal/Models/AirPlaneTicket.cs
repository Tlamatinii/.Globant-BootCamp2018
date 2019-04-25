using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using LandingFinal.Patterns;

namespace LandingFinal.Models
{
    public class AirPlaneTicket : Product
    {
        [Display(Name ="Number of Flight")]
        public int FlightNumber { get; set; }
        
        [StringLength(50)]
        public string Destiny { get; set; }

        public AirPlaneTicket() { }

        public AirPlaneTicket(string destiny, float price, int flightNumber) : base(price)
        {
            this.Price = price;
            this.Destiny = destiny;
            this.FlightNumber = flightNumber;
            this.Description = "Ticket";
            this.Type = ProductEnum.AirPlaneTicket;
        }
    }
}