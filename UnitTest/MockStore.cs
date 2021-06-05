using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using WingTipToys.BusinessLogic;
using WingTipToys.DTO;

namespace UnitTest
{
    class MockStores
    {
        public static Mock<IProductLogic> MockProductLogic()
        {
            
            var mock = new Mock<IProductLogic>();

            // void GetCarsFromProduct();
            mock.Setup(x => x.GetCarsFromProduct())
                .Returns(GetCarsMock());

             return mock;
        }
        public static List<ProductDTO> GetCarsMock() 
        {
            return new List<ProductDTO>() {
                new ProductDTO() {
                    ProductId = 1,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included).Power it up and let it go!",
                    ImagePath = "carconvert.png",
                    UnitPrice = 22.5,
                    CategoryId = 1
                },
                new ProductDTO()
                {
                    ProductId = 2,
                    ProductName = "Old-time Car",
                    Description = "There's nothing old about this toy car, except it's looks. Compatible with other old toy cars.",
                    ImagePath = "carearly.png",
                    UnitPrice = 15.95,
                    CategoryId = 1
                },
                new ProductDTO()
                {
                    ProductId = 3,
                    ProductName = "Fast Car",
                    Description = "Yes this car is fast, but it also floats in water.",
                    ImagePath = "carfast.png",
                    UnitPrice = 32.99,
                    CategoryId = 1
                },
                new ProductDTO()
                {
                    ProductId = 4,
                    ProductName = "Super Fast Car",
                    Description = "Use this super fast car to entertain guests. Lights and doors work!",
                    ImagePath = "carfaster.png",
                    UnitPrice = 8.95,
                    CategoryId = 1
                },
                new ProductDTO()
                {
                    ProductId = 5,
                    ProductName = "Old Style Racer",
                    Description = "This old style racer can fly (with user assistance). Gravity controls flight duration.No batteries required.",
                    ImagePath = "carracer.png",
                    UnitPrice = 34.95,
                    CategoryId = 1
                }
            };
        }
    }
}