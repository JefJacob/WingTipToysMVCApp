using System;
using System.Collections.Generic;

#nullable disable

namespace WingTipToys.DTO
{
    public partial class CartItemDTO
    {
        public string ItemId { get; set; }
        public string CartId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public int ProductId { get; set; }

        public virtual ProductDTO Product { get; set; }
    }
}
