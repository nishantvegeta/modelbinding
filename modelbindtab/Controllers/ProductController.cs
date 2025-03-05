using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using modelbindtab.Models;

namespace modelbindtab.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var products = new List<ProductModel>{
                new ProductModel(),
                new ProductModel(),
                new ProductModel(),
                new ProductModel(),
                new ProductModel()
            };
            return View(products);
        }

        [HttpPost]
        public IActionResult Save(List<ProductModel> products)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", products);
            }
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Unit: {product.Unit}, Quantity: {product.Quantity}, Description: {product.Description}");
            }
            return RedirectToAction("Index");
        }
    }
}