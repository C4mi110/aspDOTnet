using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNet.Models
{
    public interface IProductRepository
    {
        IQueryable<ProductModel> Products { get; }
    }
}
