using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Domain.Models;
using Ecommerce.Service.ViewModels;
using Ecommerce.Service.ViewModels.Homepage;
using Ecommerce.Service.ViewModels.ProductDetail;
using EcommerceCommon.Infrastructure.ViewModel;

namespace Ecommerce.Service.Interface
{
    public  interface IProductService : IServices<Product>
    {
        Task<List<ProductHomepage>> GetHotTrendProduct();
        Task<List<ProductHomepage>> GetProductTopView();
        Task<List<ProductListViewModel>> GetProductByCategoryLevel2(Guid CategoryId);
        Task<List<ProductListViewModel>> GetProductByCategoryLevel1(Guid CategoryId);
        Task<ProductViewModel> GetProductByProductId(Guid ProductId);
    }
}
