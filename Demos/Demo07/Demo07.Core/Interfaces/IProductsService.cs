using Demo07.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo07.Core.Interfaces
{
    public interface IProductsService
    {
        Product GetProductById(int id);
        List<Product> GetAllProducts();
    }
}
