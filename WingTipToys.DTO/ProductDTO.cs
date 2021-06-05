using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingTipToys.DTO
{
    public class ProductDTO : IComparable<ProductDTO>
    {
        public ProductDTO() 
        {
            CartItems = new HashSet<CartItemDTO>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public double? UnitPrice { get; set; }
        public int? CategoryId { get; set; }

        public virtual CategoryDTO Category { get; set; }
        public virtual ICollection<CartItemDTO> CartItems { get; set; }

        public int CompareTo(ProductDTO other)
        {
            return this.ProductId.CompareTo(((ProductDTO)other).ProductId);
        }

        public override bool Equals(object other)
        {
            return (other is ProductDTO) && ((ProductDTO)other).ProductId == ProductId
                && ((ProductDTO)other).ProductName == ProductName
                && ((ProductDTO)other).Description == Description
                && ((ProductDTO)other).UnitPrice == UnitPrice
                && ((ProductDTO)other).CategoryId == CategoryId;
        }

        public override int GetHashCode()
        {
            return ProductId;
        }
    }
}
