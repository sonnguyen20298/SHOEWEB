using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Domain.Models
{
    public class Cart :BaseModel
    {
        public decimal TotalAmount { get; set; }
        #region Relationship
        public virtual ICollection<CartDetail> CartDetails { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        #endregion
    }
}
