using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingTipToys.Repo.Models;
using WingTipToys.Entities;

namespace WingTipToys.BusinessLogic
{
    public class CartItemLogic 
    {
        private CartItemRepo _repo;
        public CartItemLogic()
        {
            _repo = new CartItemRepo();
            //TO DO AutoMapper + DTO
        }
        public void Create(CartItem cartItem)
        {

            _repo.Create(cartItem);
        }
        public CartItem Read(string Id)
        {

            return _repo.Read(Id);
        }

        public void Update(CartItem cartItem)
        {

            _repo.Update(cartItem);
        }
        public void Delete(string Id)
        {
            _repo.Delete(Id);
        }
    }
}
