using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Service.ViewModels.Homepage
{
    public class ProductHomepageViewModel : CollectionHompageViewModel
    {
        public decimal Price { get; set; }
        public decimal PriceSale { get; set; }
    }
}
