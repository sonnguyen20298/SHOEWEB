using Ecommerce.Service.Dto;
using Ecommerce.Service.ViewModels.Homepage;
using EcommerceCommon.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Service.ViewModels.ProductDetail
{
    public class ProductDetailModel
    {
        public ProductViewModel ProductViewModel { get; set; }
        public IList<ProductSizeViewModel> ProductSizeViewModel { get; set; }
        public IList<ProductImageViewModel> ProductImageViewModel { get; set; }
    }
}
