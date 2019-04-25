using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using LandingFinal.Models;
using LandingFinal.Patterns;

namespace LandingFinal.ViewModels
{
    public class CreateSaleViewModel
    {
        [Required]
        [EnumDataType(typeof(ClientEnum))]
        public string Client { get; set; }

        [Required]
        public int Passangers { get; set; }

        [Required]
        public int Nights { get; set; }

        public Guid PackageId { get; set; }
        public Guid SaleId { get; set; }

        public IEnumerable<Package> Packages { get; set; }
        public IEnumerable<Sale> Sales { get; set; }
        public IEnumerable<Product> Products { get; set; }
        
    }
}