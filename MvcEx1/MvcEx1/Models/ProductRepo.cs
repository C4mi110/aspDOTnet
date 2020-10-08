using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEx1.Models
{
    public class ProductRepo : IProductRepo
    {
        public IEnumerable<ProductModel> GetProducts()
        {
            return new List<ProductModel> {
                new ProductModel { Name = "Jeden", Description = "First", Price = 1 },
                new ProductModel { Name = "Dwa", Description = "Second", Price = 2 },
                new ProductModel { Name = "Trzy", Description = "Third", Price = 3 },
            };
        }
    }
}
