using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LandingFinal.Models;
using LandingFinal.DAL;

namespace LandingFinal.Controllers
{
    public class HomeController : Controller
    {

        private UnitOfWork unitOfWork = new UnitOfWork();
        public AgencyContext db = new AgencyContext();
        public IEnumerable<Package> ll;

        public ActionResult Index()
        {
            /*
            CarRental p1 = new CarRental(1, "Alquiler auto", 100, 1);
            PlaneTicket p2 = new PlaneTicket(2, "Pasaje aereo primera clase", 10000, 3);
            Hotel p3 = new Hotel(3, "Hotel 3 estrellas", 150, 2);
            List<Product> listp = new List<Product>();
            listp.Add(p1);
            listp.Add(p2);
            listp.Add(p3);

            TravelPackage t = new TravelPackage(1,"Bariloche premium");
            t.Products = listp;

            uow.Products.Add(p1);
            uow.Products.Add(p2);
            uow.Products.Add(p3);
            uow.Packages.Add(t);*/

            //TravelPackage t = uow.Packages.Get(1);
            // List<Product> products = t.Products;
            return View();

        }

        public JsonResult GetPackages(String text)
        {

            //IEnumerable < TravelPackage > packages = uow.Packages.GetAll();
            IEnumerable<Package> packages = unitOfWork.PackageRepository.Get(x => x.PackageName.Contains(text));

            return Json(packages, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDetails(int id)
        {
            Package t = unitOfWork.PackageRepository.GetByID(id);
            List<Product> products = t.Products;

            return Json(products, JsonRequestBehavior.AllowGet);
        }

        /*public JsonResult CalculateCommission()
        {

        }*/

    }
}
