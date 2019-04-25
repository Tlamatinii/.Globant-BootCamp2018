namespace LandingFinal.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Collections.Generic;
    using System.Linq;
    using LandingFinal.Models;
    using LandingFinal.Patterns;

    internal sealed class Configuration : DbMigrationsConfiguration<LandingFinal.DAL.AgencyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LandingFinal.DAL.AgencyContext context)
        {
            var packages = new List<Package>
            {
                new Package {PackageName = "Bariloche Premium",
                    Products = new List<Product>
                    {
                        new AirPlaneTicket{Description="Air Plane Ticket", Price=300, Type = ProductEnum.AirPlaneTicket, Id = Guid.NewGuid(), Category =2, Destiny = "Argentina", FlightNumber = 10},
                        new Hotel{Description="Hotel", Price=140, Type = ProductEnum.Hotel, Id = Guid.NewGuid(), Category = 3, HotelName = "Pico Nevado"},
                        new CarRental{Description="Car", Price=500, Type = ProductEnum.CarRental, Id = Guid.NewGuid(), Category = 3, CarModel = "Honda"}
                    },
                    Id = Guid.NewGuid()},

                new Package {PackageName = "Berlin Travel",
                    Products = new List<Product>
                    {
                         new AirPlaneTicket{Description="Air Plane Ticket", Price=460, Type = ProductEnum.AirPlaneTicket, Id = Guid.NewGuid(), Category =3, Destiny = "Rusia", FlightNumber = 30},
                         new Hotel{Description="Hotel", Price=100, Type = ProductEnum.Hotel, Id = Guid.NewGuid(), Category = 2 , HotelName = "Cold Soul"},
                    },
                    Id = Guid.NewGuid()},

                new Package {PackageName = "Miami Express",
                    Products = new List<Product>{
                        new AirPlaneTicket{Description="Air Plane Ticket", Price=100, Type = ProductEnum.AirPlaneTicket, Id = Guid.NewGuid(), Category =1, Destiny = "EE.UU", FlightNumber = 50},
                        new Hotel{Description="Hotel", Price=50, Type = ProductEnum.Hotel, Id = Guid.NewGuid(), Category = 1, HotelName = "Miami resort"},
                        new CarRental{Description="Car Rental", Price = 20, Type = ProductEnum.CarRental, Id = Guid.NewGuid(), Category = 1, CarModel = "Ford"}
                    },
                    Id = Guid.NewGuid()}
            };
            packages.ForEach(s => context.Packages.AddOrUpdate(p => p.PackageName, s));
            context.SaveChanges();
        }
    }
}
