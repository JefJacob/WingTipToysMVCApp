using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingTipToys.Repo.Models;
using WingTipToys.Entities;
using AutoMapper;
using WingTipToys.DTO;
using WingTipToys.Repo.Interfaces;
using WingTipToys.BusinessLogic.Interfaces;

namespace WingTipToys.BusinessLogic.Business
{
    public class ProductLogic : BaseLogic<Product, ProductDTO>, IProductLogic
    {
        private new readonly IProductRepo _repo;
        private new readonly IMapper _mapConfig;

        public ProductLogic(IProductRepo repo, IMapper mapConfig ) : base(repo, mapConfig)
        {
            _repo = repo;
            _mapConfig = mapConfig;
        }

        public List<ProductDTO> GetProductByType(int categoryId)
        {

            var cars = _repo.GetProductByType(categoryId).ToList<Product>();
            return _mapConfig.Map<List<Product>, List<ProductDTO>>(cars);
            
        }
    }
}
