using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.Domain.Models
{
    public class Category:BaseModel
    {
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public int? Sort { get; set; }
        public Guid? ParentId { get; set; }
        public string URLImage { get; set; }
        public bool IsCollection { get; set; }
        #region Relationship
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Coupon> Coupons { get; set; }
        public virtual ICollection<CollectionImage> CollectionImages { get; set; }
        #endregion
    }
}
