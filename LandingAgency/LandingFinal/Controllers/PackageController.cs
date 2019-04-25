using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LandingFinal.DAL;
using LandingFinal.Models;
using LandingFinal.ViewModels;

namespace LandingFinal.Controllers
{
    public class PackageController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        // GET: Package
        public ActionResult Index(string sortOrder, string searchString, Guid? Id, Guid? ProductId)
        {
            var viewModel = new CreateSaleViewModel();
            viewModel.Packages = unitOfWork.context.Packages
                .Include(i => i.PackageName)
                .Include(i => i.Products.Select(c => c.Description))
                .OrderBy(i => i.PackageName);

            var products = from s in unitOfWork.context.Packages
                           select s;
            var packages = unitOfWork.PackageRepository.Get(includeProperties: "");
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            var packagess = from s in unitOfWork.context.Packages
                            select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                packagess = packagess.Where(s => s.PackageName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    packagess = packagess.OrderByDescending(s => s.PackageName);
                    break;
                default:
                    packagess = packagess.OrderBy(s => s.PackageName);
                    break;
            }


            return View(packagess);
        }

        // GET: Package/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Package package = unitOfWork.PackageRepository.GetByID(id);
            if (package == null)
            {
                return HttpNotFound();
            }
            return View(package);
        }

        // GET: Package/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Package/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PackageName")] Package package)
        {
            if (ModelState.IsValid)
            {
                package.Id = Guid.NewGuid();
                unitOfWork.PackageRepository.Insert(package);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }

            return View(package);
        }

        // GET: Package/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Package package = unitOfWork.PackageRepository.GetByID(id);
            if (package == null)
            {
                return HttpNotFound();
            }
            return View(package);
        }

        // POST: Package/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PackageName")] Package package)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.PackageRepository.Update(package);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View(package);
        }

        // GET: Package/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Package package = unitOfWork.PackageRepository.GetByID(id);
            if (package == null)
            {
                return HttpNotFound();
            }
            return View(package);
        }

        // POST: Package/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Package package = unitOfWork.PackageRepository.GetByID(id);
            unitOfWork.PackageRepository.Delete(package);
            unitOfWork.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
