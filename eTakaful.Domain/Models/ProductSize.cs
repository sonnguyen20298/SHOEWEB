using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Domain.Models
{
    public class ProductSize :BaseModel
    {
        public int Size { get; set; }
        public int CountStock { get; set; }
        public decimal Price { get; set; }
        #region Relationship
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        #endregion
    }
}
