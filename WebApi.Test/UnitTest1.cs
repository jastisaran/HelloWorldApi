using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using WebApi.Controllers;
using BusinessServices;
using Moq;
using System.Web.Http;

namespace WebApi.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void GetDatesShouldReturnDatesFromRepository()
        {
            //Arrange
            var mockRepository = new Mock<IProductServices>();


            ProductController controller = new ProductController(mockRepository.Object);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            //Act            
            var response = controller.Get();

            //Assert
            Assert.AreEqual(response, "Hello World");
        }


    }
}
