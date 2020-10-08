using System.Collections.Generic;

namespace MvcEx1.Models
{
    public interface IProductRepo
    {
        IEnumerable<ProductModel> GetProducts();
    }
}