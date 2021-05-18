using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCommon.Infrastructure.ViewModel
{
    public class ProductHomepage : CollectionHomepage
    {
        public decimal Price { get; set; }
        public decimal PriceSale { get; set; }
    }
}
