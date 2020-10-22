﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspDotNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNet.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;
        public ProductController(IProductRepository repository)
        {
            this.repository = repository;
        }
        public ViewResult List() => View(repository.Products);
    }
}
