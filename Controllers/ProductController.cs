using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductManager.Models;

namespace ProductManager.Controllers
{
    public class ProductController : Controller
    {
        public List<Product> Products { get; set; }

        public ProductController()
        {
            Products = new List<Product>()
            {
                new Product { Id = 1, Name = "Iphone 1", Price = 100, Quantity = 10 },
                new Product { Id = 2, Name = "Iphone 2", Price = 200, Quantity = 20 },
                new Product { Id = 3, Name = "Iphone 3", Price = 300, Quantity = 30 },
                new Product { Id = 4, Name = "Iphone 4", Price = 400, Quantity = 40 },
                new Product { Id = 5, Name = "Iphone 5", Price = 500, Quantity = 50 },
                new Product { Id = 6, Name = "Iphone 6", Price = 600, Quantity = 60 },
                new Product { Id = 7, Name = "Iphone 7", Price = 700, Quantity = 70 },
                new Product { Id = 8, Name = "Iphone 8", Price = 800, Quantity = 80 },
                new Product { Id = 9, Name = "Iphone 9", Price = 900, Quantity = 90 },
                new Product { Id = 10, Name = "Iphone 10", Price = 1000, Quantity = 100 },
            };
        }

        public IActionResult Index()
        {
            return View(Products);
        }
    }
}