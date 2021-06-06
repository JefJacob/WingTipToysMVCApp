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
    public class CartItemRepo : BaseRepo<CartItem>, ICartItemRepo
    {
        private WingTipToysContext _context;
        public CartItemRepo(WingTipToysContext context):base(context)
        {
            _context = context;
        }
    }
}
