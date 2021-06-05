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

namespace WingTipToys.BusinessLogic
{
    public class ProductLogic : BaseLogic<Product, ProductDTO>, IProductLogic
    {
        private new readonly IProductRepo _repo;
        private new readonly IMapper _mapConfig;
        public ProductLogic() :base()
        {
            _mapConfig = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<Product, ProductDTO>();
                    cfg.CreateMap<ProductDTO, Product>();
                }).CreateMapper();
            _repo = new ProductRepo();
        }
        public List<ProductDTO> GetCarsFromProduct()
        {
            
            List<ProductDTO> carsDTO = new List<ProductDTO>(); 
            _repo.ReadAllCars().ForEach(car => {
                    carsDTO.Add(_mapConfig.Map<ProductDTO>(car));
                });
            return carsDTO;
        }
    }
}
