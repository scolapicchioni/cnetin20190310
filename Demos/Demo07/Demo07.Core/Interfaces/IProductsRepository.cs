using Demo07.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo07.Core.Interfaces
{
    public interface IProductsRepository
    {
        Product GetProductById(int id);
        List<Product> GetAllProducts();
    }
}
