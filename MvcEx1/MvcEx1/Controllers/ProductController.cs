using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcEx1.Models;

namespace MvcEx1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo repo;

        public ProductController(IProductRepo repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowProducts()
        {
            return View(repo.GetProducts());
        }
    }
}
