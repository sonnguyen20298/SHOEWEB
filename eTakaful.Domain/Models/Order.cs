using Ecommerce.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.Domain.Models
{
    public class Order :BaseModel
    {
        [StringLength(100)]
        public string CustomerName { get; set; }
        [StringLength(200)]
        public string Address { get; set; }
        [StringLength(100)]
        public string Phone { get; set; }       
        [StringLength(100)]
        public string Email { get; set; }        
        [StringLength(100)]
        public string Descriptions { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.OrderSuccess;
        public decimal TotalAmount { get; set; }
        #region Relationship
        public Guid UserId { get; set; } 
        public virtual User User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<OrderHistory> OrderHistories { get; set; }
       
        #endregion
    }

    // Thieu order status  = > enum
    // thieu order history : thoi gian lich su tung giai doan , so luon san pham mua hang
}
