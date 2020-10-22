using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNet.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<ProductModel> Products =>
           new List<ProductModel> {
                new ProductModel { Id = 1, Name = "Jeden", Description = "First", Price = 1, Category = "owoc" },
                new ProductModel { Id = 2, Name = "Dwa", Description = "Second", Price = 2, Category = "owoc" },
                new ProductModel { Id = 3, Name = "Trzy", Description = "Third", Price = 3, Category = "owoc" },
            }.AsQueryable<ProductModel>();
    }
}
