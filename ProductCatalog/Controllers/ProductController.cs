using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> p = GetProducts();
            return View(p);
        }
        private List<Product> GetProducts()
        {
            List<Product> p = new List<Product>();

            Product p1 = new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 55000,
                Category = "Electronics",
                ImageUrl = "/Content/images/laptop.jpg"
            };
            p.Add(p1);

            Product p2 = new Product
            {
                Id = 2,
                Name = "Mobile",
                Price = 25000,
                Category = "Electronics",
                ImageUrl = "/Content/images/mobile.jpg"
            };
            p.Add(p2);

            Product p3 = new Product
            {
                Id = 3,
                Name = "Buggati",
                Price = 23400000,
                Category = "Gaddi",
                ImageUrl = "/Content/images/bugatti.jpg"
            };
            p.Add(p3);

            return p;
        }
    }
}