using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LandingFinal.Models;
using LandingFinal.ViewModels;
using LandingFinal.DAL;

namespace LandingFinal.Controllers
{
    public class SaleController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        // GET: Sale
        public ActionResult Index(string sortOrder, string searchString, Guid? Id, Guid? ProductId)
        {

            var product = from s in unitOfWork.context.Products
                          select s;
            var packages = from s in unitOfWork.context.Packages
                           select s;

            var viewmodel = new CreateSaleViewModel();
            viewmodel.Packages = unitOfWork.context.Packages
                .Include(i => i.PackageName)
                .Include(i => i.Products.Select(c => c.Description))
                .OrderBy(i => i.PackageName);

            if (Id != null)
            {
                ViewBag.InstructorID = Id.Value;
                viewmodel.Products = viewmodel.Packages.Where(
                    i => i.Id == Id.Value).Single().Products;
            }

            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            if (!String.IsNullOrEmpty(searchString))
            {
                packages = packages.Where(s => s.PackageName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    packages = packages.OrderByDescending(s => s.PackageName);
                    break;
                default:
                    packages = packages.OrderBy(s => s.PackageName);
                    break;
            }

            var sales = from s in unitOfWork.context.Sales
                        select s;
            var viewModel = new CreateSaleViewModel
            {
                Packages = packages,
                Sales = sales,
                Products = product
            };
            return View(viewModel);
        }

        // GET: Sale/Details/packageName
        public ActionResult Details(Guid? id)
        {
            Package package = unitOfWork.PackageRepository.GetByID(id);
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,PackageName")] Sale sale)
        {
            if (ModelState.IsValid)
            {
                sale.Id = Guid.NewGuid();
                unitOfWork.SaleRepository.Insert(sale);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }
         
            return View();
        }

        // GET: Sale/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sale/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sale/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sale/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sale/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sale/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
