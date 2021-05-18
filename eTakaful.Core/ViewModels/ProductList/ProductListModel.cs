using Ecommerce.Service.Dto;
using Ecommerce.Service.ViewModels.Homepage;
using EcommerceCommon.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Service.ViewModels.ProductList
{
    public class ProductListModel
    {
        public IList<ProductListViewModel> ProductListViewModel { get; set; }
        public CategoryProductListViewModel CategoryProductListViewModel { get; set; }
    }
}
