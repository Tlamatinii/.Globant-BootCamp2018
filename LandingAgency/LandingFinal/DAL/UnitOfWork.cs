using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LandingFinal.Models;

namespace LandingFinal.DAL
{
    public class UnitOfWork : IDisposable
    {
        public AgencyContext context = new AgencyContext();
        private GenericRepository<Product> productRepository;
        private GenericRepository<Package> packageRepository;
        private GenericRepository<AirPlaneTicket> airPlaneTicketRepository;        
        private GenericRepository<Hotel> hotelRepository;
        private GenericRepository<Sale> saleRepository;
        private GenericRepository<CarRental> carRentalRepository;

        public GenericRepository<Product> ProductRepository
        {
            get
            {
                if (this.productRepository == null)
                {
                    this.productRepository = new GenericRepository<Product>(context);
                }
                return productRepository;
            }
        }

        public GenericRepository<Package> PackageRepository
        {
            get
            {
                if (this.packageRepository == null)
                {
                    this.packageRepository = new GenericRepository<Package>(context);
                }
                return packageRepository;
            }
        }



        public GenericRepository<AirPlaneTicket> AirPlaneTicketRepository
        {
            get
            {

                if (this.airPlaneTicketRepository == null)
                {
                    this.airPlaneTicketRepository = new GenericRepository<AirPlaneTicket>(context);
                }
                return airPlaneTicketRepository;
            }
        }

        

        public GenericRepository<Hotel> HotelRepository
        {
            get
            {

                if (this.hotelRepository == null)
                {
                    this.hotelRepository = new GenericRepository<Hotel>(context);
                }
                return hotelRepository;
            }
        }

        public GenericRepository<Sale> SaleRepository
        {
            get
            {

                if (this.saleRepository == null)
                {
                    this.saleRepository = new GenericRepository<Sale>(context);
                }
                return saleRepository;
            }
        }

        public GenericRepository<CarRental> CarRentalRepository
        {
            get
            {

                if (this.carRentalRepository == null)
                {
                    this.carRentalRepository = new GenericRepository<CarRental>(context);
                }
                return carRentalRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
