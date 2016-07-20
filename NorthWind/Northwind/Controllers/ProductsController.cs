using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Add
using Northwind.Models;

namespace Northwind.Controllers
{
    public class ProductsController : Controller
    {
        NorthwindDBContext db = new NorthwindDBContext();

        //
        // GET: /Products/
        public ActionResult Index()
        {
            List<Product> listProducts = db.Products.ToList();

            return View(listProducts);
        }

        //
        // GET: /Products/Details/5
        public ActionResult Details(int id)
        {
            // check
            if (id <= 0)
            {
                // throw error
                object errorMessage = string.Format("Product ID = {0} is not valid", id);
                return View("Notification", errorMessage);
            }

            Product product = db.Products.Find(id);
            return View(product);
        }

        //
        // GET: /Products/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Products/Create
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

        //
        // GET: /Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Products/Edit/5
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

        //
        // GET: /Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Products/Delete/5
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
