using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspWebShopApp.Models
{
    public interface IProductRepository
    {
        IQueryable<ProductModel> Products { get; }
        void SaveProduct(ProductModel product);
        ProductModel DeleteProduct(int productId);
    }
}
