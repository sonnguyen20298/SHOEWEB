using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCommon.Infrastructure.ViewModel
{
    public class ProductCartViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImageLink { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}

