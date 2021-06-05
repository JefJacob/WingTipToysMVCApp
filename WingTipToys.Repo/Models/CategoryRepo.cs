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
    public class CategoryRepo : BaseRepo<Category>, ICategoryRepo
    {
        private WingTipToysContext _context;
        public CategoryRepo()
        {
            _context = new WingTipToysContext();
        }
    }
}
