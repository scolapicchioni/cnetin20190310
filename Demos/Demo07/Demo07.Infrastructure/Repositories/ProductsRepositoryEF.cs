using Demo07.Core.Entities;
using Demo07.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo07.Infrastructure.Repositories
{
    public class ProductsRepositoryEF : IProductsRepository
    {
        public Product GetProductById(int id) {
            //go to talk to Entity Framework
            //execute a query
            //return the product (or null)

            return new Product() { Id = id, Name = "Latitude ES570", Brand = "Dell", Price = 1234 };
        }
        public List<Product> GetAllProducts() {
            return new List<Product>() {
                new Product() { Id = 1, Name = "Latitude ES570", Brand = "Dell", Price = 1234 },
                new Product() { Id = 2, Name = "Monitor", Brand = "Dell", Price = 234 },
            };
        }
    }
}
