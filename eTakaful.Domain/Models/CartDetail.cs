using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Domain.Models
{
    public class CartDetail :BaseModel
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        #region Relationship
        public Guid CartId { get; set; }
        public virtual Cart Cart { get; set; }
        public Guid ProductSizeId { get; set; }
        public virtual ProductSize ProductSize { get; set; }
        #endregion
    }
}
