using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Domain.Models
{
    public class OrderDetail :BaseModel
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        #region Relationship
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
        public Guid ProductSizeId { get; set; }
        public virtual ProductSize ProductSize { get; set; }
        #endregion
    }
}
