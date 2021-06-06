using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WingTipToys.BusinessLogic;
using WingTipToys.BusinessLogic.Interfaces;
using WingTipToys.DTO;
using WingTipToys.Entities;
using WingTipToysWebApp.Models;

namespace WingTipToysWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductLogic _logic;
        public ProductController(IProductLogic logic)
        {
            _logic = logic;
            
        }
        
        public IActionResult Index()
        {
            int categoryId = 1;//for car
            return View(_logic.GetProductByType(categoryId));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
