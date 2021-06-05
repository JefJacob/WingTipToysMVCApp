using System;
using System.Collections.Generic;

#nullable disable

namespace WingTipToys.DTO
{
    public partial class CategoryDTO
    {
        public CategoryDTO()
        {
            Products = new HashSet<ProductDTO>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ProductDTO> Products { get; set; }
    }
}
