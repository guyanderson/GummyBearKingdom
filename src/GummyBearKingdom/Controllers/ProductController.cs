﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummyBearKingdom.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GummyBearKingdom.Controllers
{
    public class ProductController : Controller
    {
        private GummyBearKingdomContext db = new GummyBearKingdomContext();
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }

    }
}
