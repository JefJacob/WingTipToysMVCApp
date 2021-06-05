using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingTipToys.Repo.Models;
using WingTipToys.Entities;

namespace WingTipToys.BusinessLogic
{
    public class OrderLogic
    {
        private OrderRepo _repo;
        public OrderLogic()
        {
            _repo = new OrderRepo();
            //TO DO AutoMapper + DTO
        }
        public void Create(Order order)
        {

            _repo.Create(order);
        }
        public Order Read(int Id)
        {

            return _repo.Read(Id);
        }

        public void Update(Order order)
        {

            _repo.Update(order);
        }
        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }
    }
}
