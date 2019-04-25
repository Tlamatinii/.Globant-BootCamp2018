using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LandingFinal.Patterns;
using LandingFinal.Patterns.Commision.CorporateClient;
using LandingFinal.Patterns.Commision.IndividualClient;
using LandingFinal.DAL;

namespace LandingFinal.Models
{
    public class Sale
    {
        private UnitOfWork unit = new UnitOfWork();

        [Key]
        public Guid Id { get; set; }

        [Required]
        int Passangers { get; set; }

        [Required]
        int nights { get; set; }

        private ClientEnum ClientType { get; set; }

        public Dictionary<ClientEnum, Dictionary<ProductEnum, CalculateCommision>> Strategy;

        public virtual IList<Product> SaleItems { get; set; }

        private List<Package> SalePackage = new List<Package>();

        private float Total = 0;

        public Sale() { }

        public int Pässangers
        {
            set
            {
                if (value > 0 && value <= 10)
                {
                    Pässangers = value;
                }
            }
        }

        public ClientEnum setClient
        {
            set { ClientType = value; }
        }

        public int Nights { get; set; }

        public void addPackage(Package t)
        {
            unit.PackageRepository.Insert(t);
        }

        public void removePackage(Package t)
        {

            unit.PackageRepository.Delete(t);
        }

        public Sale(int nights, int passenger, List<Product> items, Package package)
        {
            
            Nights = nights;
            Passangers = passenger;
            Strategy = GetCalculationStrategy();
            this.SaleItems = new List<Product>();
            package.Products = items;
            foreach (var item in items)
                {
                    this.SaleItems.Add(item);
                }
        }
        

        public float CalculateComission()
        {
            float totalCommission = 0;
            foreach (Package package in SalePackage)
            {
                foreach (var item in SaleItems)
                {
                    totalCommission += Strategy[ClientType][item.Type].CalculateProductCommision(item, Nights);
                    Total += totalCommission;
                }              
            }
            return Total * Passangers;
        }
        

        Dictionary<ClientEnum,  Dictionary<ProductEnum, CalculateCommision>> GetCalculationStrategy()
        {
            var productStrategy = new Dictionary<ProductEnum, CalculateCommision>();
            var clientStrategy = new Dictionary<ClientEnum, Dictionary<ProductEnum, CalculateCommision>>();

            clientStrategy[ClientEnum.Corporate].Add(ProductEnum.Hotel, new CorporateHotel());
            clientStrategy[ClientEnum.Corporate].Add(ProductEnum.AirPlaneTicket, new CorporateTicket());
            clientStrategy[ClientEnum.Corporate].Add(ProductEnum.CarRental, new CorporateCar());
            clientStrategy[ClientEnum.Individual].Add(ProductEnum.Hotel, new IndividualHotel());
            clientStrategy[ClientEnum.Individual].Add(ProductEnum.AirPlaneTicket, new IndividualTicket());
            clientStrategy[ClientEnum.Individual].Add(ProductEnum.CarRental, new IndividualCarRental());
            return clientStrategy;

        }
        

    }
}