using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspWebShopApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspWebShopApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;
        public ProductController(IProductRepository repo)
        {
            this.repository = repo;
        }
        public ViewResult ListAll() => View(repository.Products);

        public ViewResult List(string category) => View(repository.Products.Where(p => p.Category == category));

        public IActionResult Index() 
        {
            return View();
        }
    }
}
