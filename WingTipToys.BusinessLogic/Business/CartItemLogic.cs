using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingTipToys.Repo.Models;
using WingTipToys.Entities;
using WingTipToys.DTO;
using AutoMapper;
using WingTipToys.BusinessLogic.Interfaces;

namespace WingTipToys.BusinessLogic.Business
{
    public class CartItemLogic : BaseLogic<CartItem, CartItemDTO>, ICartItemLogic
    {


    }
}
