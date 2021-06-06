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

        public ProductLogic(IProductRepo repo) : base(repo)
        {
            _repo = repo;
            _mapConfig = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<Product, ProductDTO>();
                    cfg.CreateMap<ProductDTO, Product>();
                }).CreateMapper();
        }

        public List<ProductDTO> GetCarsFromProduct()
        {

            var cars = _repo.ReadAllCars().ToList<Product>();
            return _mapConfig.Map<List<Product>, List<ProductDTO>>(cars);
            
        }
    }
}
