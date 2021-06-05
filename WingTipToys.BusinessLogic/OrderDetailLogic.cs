using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingTipToys.Repo.Models;
using WingTipToys.Entities;

namespace WingTipToys.BusinessLogic
{
    public class OrderDetailLogic
    {
        private OrderDetailRepo _repo;
        public OrderDetailLogic()
        {
            _repo = new OrderDetailRepo();
            //TO DO AutoMapper + DTO
        }
        public void Create(OrderDetail orderDetail)
        {

            _repo.Create(orderDetail);
        }
        public OrderDetail Read(int Id)
        {

            return _repo.Read(Id);
        }

        public void Update(OrderDetail orderDetail)
        {

            _repo.Update(orderDetail);
        }
        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }
    }
}
