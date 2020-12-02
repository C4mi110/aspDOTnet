using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspWebShopApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspWebShopApp.Controllers
{
    public class AdminController : Controller
    {
        private IProductRepository repository;
        public AdminController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index()
        {
            return View(repository.Products);
        }
        public ViewResult Edit(int Id) 
        {
            return View(repository.Products.FirstOrDefault(p => p.Id == Id));
        }

        [HttpPost]
        public IActionResult Save(ProductModel product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = $"Zapis {product.Name}";
                return RedirectToAction("Index");
            }
            else 
            {
                return View("Edit", product);
            }
        }
        public ViewResult Create()
        {
            return View("Edit", new ProductModel());
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            ProductModel deletedProduct = repository.DeleteProduct(Id);
            if (deletedProduct != null)
            {
                TempData["message"] = $"Usuń {deletedProduct.Name}";
            }
            return RedirectToAction("Index");
        }


    }
}
