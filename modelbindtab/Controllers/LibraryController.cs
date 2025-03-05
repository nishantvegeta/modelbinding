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
    public class LibraryController : Controller
    {
        private static List<LibraryModel> libraries = new List<LibraryModel>
        {
            new LibraryModel{Id = 1, Name = "Library 1", Stall = "Stall 1", Address = "Address 1", OpenDate = DateTime.Now, Email = "lib@gmail.com"},
            new LibraryModel{Id = 2, Name = "Library 2", Stall = "Stall 2", Address = "Address 2", OpenDate = DateTime.Now, Email = "lib2@gmail.com"},
            new LibraryModel{Id = 3, Name = "Library 3", Stall = "Stall 3", Address = "Address 3", OpenDate = DateTime.Now, Email = "lib3@gmail.com"},
        };

        public IActionResult Index()
        {
            return View(libraries);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LibraryModel libraryModel)
        {
            if (!ModelState.IsValid)
            {
                return View(libraryModel);                
            }

            libraries.Add(libraryModel);

            return RedirectToAction("Index");
        }
    }
}