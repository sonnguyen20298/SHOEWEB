using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Domain.Enums
{
    public enum OrderStatus
    {
        OrderSuccess = 0,
        OrderReceived = 1,
        FinishPacking = 2,
        Transporting = 3,
        Delivered =4
    }
}
