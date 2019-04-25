using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using LandingFinal.Models;

namespace LandingFinal.DAL
{
    public class AgencyContext : DbContext
    {
        public AgencyContext() : base("LandingDB")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<AirPlaneTicket> Tickets { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<CarRental> CarRentals { get; set; }
        public DbSet<Sale> Sales { get; set; }
        

        private static AgencyContext instance;

        public static AgencyContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AgencyContext();
                }
                return instance;
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
        }
    }
}

