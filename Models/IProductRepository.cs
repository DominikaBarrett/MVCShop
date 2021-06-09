using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sklep.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProduct { get; }
        IEnumerable<Product> GetProductOnSale { get; }
        Product GetProductById(int productId);
    }
}
