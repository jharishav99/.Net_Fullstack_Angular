using Microsoft.AspNetCore.Mvc;
using MyApp1.Controllers;
using Xunit;

namespace MyApp1.Tests
{
    public class ProductControllerTests
    {
        [Fact]
        public void Get_InvalidId_ReturnsBadRequest()
        {
            // Arrange
            var controller = new ProductController();

            // Act
            var result = controller.Get(0);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }
    }
}