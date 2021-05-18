using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.Domain.Models
{
    public class Coupon :BaseModel
    {
        [Required]
        [MaxLength(256)]
        public string Code { get; set; }
        public decimal Amount { get; set; }
        public int NumberApply { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        #region Relationship
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
        #endregion
    }
}
