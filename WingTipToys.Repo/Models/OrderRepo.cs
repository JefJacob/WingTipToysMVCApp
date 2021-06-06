using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingTipToys.Entities;
using Microsoft.EntityFrameworkCore;
using WingTipToys.Repo.Interfaces;

namespace WingTipToys.Repo.Models
{
    public class OrderRepo : BaseRepo<Order>, IOrderRepo
    {
        private WingTipToysContext _context;
        public OrderRepo(WingTipToysContext context) : base(context)
        {
            _context = context;
        }
    }
}
