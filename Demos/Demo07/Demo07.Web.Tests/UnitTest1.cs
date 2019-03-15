using Demo07.Core.Interfaces;
using Demo07.Web.Controllers;
using Moq;
using System;
using Xunit;

namespace Demo07.Web.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var m = new Mock<IProductsService>();
            //m.Setup
            ProductsController controller = new ProductsController(m.Object);

            IActionResult result = controller.GetProductById(5);

        }
    }
}
