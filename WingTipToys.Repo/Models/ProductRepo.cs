using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WingTipToys.Entities;
using WingTipToys.Repo.Interfaces;

namespace WingTipToys.Repo.Models
{
    public class ProductRepo : BaseRepo<Product> , IProductRepo
    {
        private WingTipToysContext _context;
        

        public ProductRepo(WingTipToysContext context) : base(context)
        {
            _context = context;
        }
        public List<Product> ReadAllCars()
        {
            return _context.Products.Where(p => p.CategoryId == 1).ToList<Product>();
            
        }

    }
}
