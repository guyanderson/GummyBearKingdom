using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummyBearKingdom.Models;
using Microsoft.EntityFrameworkCore;

namespace GummyBearKingdom.Controllers
{
    public class AdminController : Controller
    {
        private GummyBearKingdomContext db = new GummyBearKingdomContext();

        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }

        //Create Product Get request
        public IActionResult Create()
        {
            return View();
        }

        //Create Product Post request
        [HttpPost]
        public IActionResult Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Edit Product Get request
        public IActionResult Edit(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }

        //Edit Product Post request
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Delete Product Get request
        public IActionResult Delete(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }

        //Delete Product Post request
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            db.Products.Remove(thisProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
