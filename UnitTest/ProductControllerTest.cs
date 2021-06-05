using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WingTipToys.BusinessLogic;
using WingTipToys.DTO;
using WingTipToysWebApp.Controllers;

namespace UnitTest
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void TestIndexView()
        {
            #region Arrange
            var mockData = MockStores.MockProductLogic();
            var controller = new ProductController(mockData.Object);
            #endregion

            #region Act
            var result = controller.Index();
            #endregion

            #region Assert
            var resultModel = result as ViewResult;
            var actual = resultModel.Model as List<ProductDTO>;
            Assert.AreEqual(5, actual.Count);
            CollectionAssert.AllItemsAreInstancesOfType(actual, typeof(ProductDTO));
            #endregion


        }
    }
}
