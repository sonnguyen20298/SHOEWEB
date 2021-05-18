using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.Domain.Models
{
    public class Manufacturer :BaseModel
    {
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string CodeName { get; set; }
        [MaxLength(256)]
        public string Description { get; set; }
        [MaxLength(256)]
        public string Website { get; set; }
        [MaxLength(256)]
        public string Logo { get; set; }
        #region Relationship
        public virtual ICollection<Product> Products { get; set; }
        #endregion
    }
}
