using System.Collections.Generic;
using Demo07.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Demo07
{
    namespace Web {
        namespace Controllers {
            public class ProductsController : Controller
            {
                private readonly IProductsService _productsService;

                public ProductsController(IProductsService productsService)
                {
                    _productsService = productsService;
                }
                //http://mysite/Products/GetProducts
                public IActionResult GetProducts()
                {
                    List<Demo07.Core.Entities.Product> products = _productsService.GetAllProducts();
                    return View(products);
                }

                //http://mysite/Products/GetProductById/3
                public IActionResult GetProductById(int id)
                {
                    Demo07.Core.Entities.Product product = _productsService.GetProductById(id);
                    return View(product);
                }
            }
        }
    }
    
}