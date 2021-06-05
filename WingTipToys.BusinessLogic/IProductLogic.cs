using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingTipToys.DTO;

namespace WingTipToys.BusinessLogic
{
    public interface IProductLogic
    {
        public List<ProductDTO> GetCarsFromProduct();
    }
}
