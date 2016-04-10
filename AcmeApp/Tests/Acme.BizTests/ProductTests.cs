using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void PrintTest()
        {
            // Arrange
            var currentProduct = new Product();
            currentProduct.Id = 0;
            currentProduct.Name = "Hammer";
            currentProduct.Description = "Hack away with this shiny tool.";

            var expected = "[0] Hammer: Hack away with this shiny tool.";

            // Act
            var actual = currentProduct.Print();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ParameterizedConstructor()
        {
            // Arrange
            var currentProduct = new Product(0, "Hammer", "Hack away with this shiny tool.");
            
            var expected = "[0] Hammer: Hack away with this shiny tool.";

            // Act
            var actual = currentProduct.Print();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}