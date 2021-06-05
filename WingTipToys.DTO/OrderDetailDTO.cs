using System;
using System.Collections.Generic;

#nullable disable

namespace WingTipToys.DTO
{
    public partial class OrderDetailDTO
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public string Username { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double? UnitPrice { get; set; }

        public virtual OrderDTO Order { get; set; }
    }
}
