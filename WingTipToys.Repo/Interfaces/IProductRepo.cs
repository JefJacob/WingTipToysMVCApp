using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingTipToys.Entities;

namespace WingTipToys.Repo.Interfaces
{
    public interface IProductRepo : IRepo<Product>
    {
        public List<Product> GetProductByType(int categroyId);

    }
}
