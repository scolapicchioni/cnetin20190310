using Demo07.Core.Entities;
using Demo07.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo07.Web.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _repository;

        public ProductsService(IProductsRepository repository)
        {
            _repository = repository;
        }
        public List<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            //try to get item from the cache
            //if the item exists, return
            //if not
            //get item from the repo
            //put it in the cache
            //return the item
            return _repository.GetProductById(id);
        }
    }
}
