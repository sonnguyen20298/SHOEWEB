﻿using Ecommerce.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Domain.Models
{
    public class OrderHistory :BaseModel
    {
        public OrderStatus OrderStatus { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        #region Relationship
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
        #endregion
    }
}
