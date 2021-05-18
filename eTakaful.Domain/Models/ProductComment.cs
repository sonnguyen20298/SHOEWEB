using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Domain.Models
{
    public class ProductComment : BaseModel
    {
        public string Comment { get; set; }
        public int rating { get; set; }
        #region Relationship
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        #endregion
    }
}
