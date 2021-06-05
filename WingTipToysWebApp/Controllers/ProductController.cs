using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WingTipToys.BusinessLogic;
using WingTipToys.DTO;
using WingTipToys.Entities;
using WingTipToysWebApp.Models;

namespace WingTipToysWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductLogic _logic;
        private readonly BaseLogic<Product, ProductDTO> _baseLogic;
        public ProductController(IProductLogic logic)
        {
            _logic = logic;
            
        }
        
        public IActionResult Index()
        {
            
            return View(_logic.GetCarsFromProduct());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
