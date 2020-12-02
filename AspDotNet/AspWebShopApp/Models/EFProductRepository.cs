using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspWebShopApp.Models
{
    public class EFProductRepository : IProductRepository
    {
        private readonly AppDbContext context;
        public EFProductRepository(AppDbContext ctx)
        {
            this.context = ctx;
        }
        public IQueryable<ProductModel> Products => context.ProductModel;

        public void SaveProduct(ProductModel product)
        {
            if (product.Id == 0)
            {
                context.ProductModel.Add(product);
            }
            else
            {
                ProductModel dbEntry = context.ProductModel.FirstOrDefault(p => p.Id == product.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                }
            }
            context.SaveChanges();
        }
        public ProductModel DeleteProduct(int productID)
        {
            ProductModel dbEntry = context.ProductModel.FirstOrDefault(p => p.Id == productID);
            if (dbEntry != null)
            {
                context.ProductModel.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
