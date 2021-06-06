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
    public class OrderDetailRepo : BaseRepo<OrderDetail>, IOrderDetailRepo
    {
        private WingTipToysContext _context;
        public OrderDetailRepo(WingTipToysContext context) : base(context)
        {
            _context = context;
        }
    }
}
