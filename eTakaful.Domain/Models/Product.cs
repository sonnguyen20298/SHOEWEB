using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.Domain.Models
{
    public class Product :BaseModel
    {
        #region Property
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Keyword { get; set; }
        public string Sku { get; set; }
        public int View { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        #endregion

        #region Relationship
        public virtual ICollection<ProductSize> ProductSizes { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductStatus> ProductStatuses { get; set; }
        public virtual ICollection<ProductComment> ProductComments { get; set; }
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public Guid ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public Guid SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        #endregion
    }
}
