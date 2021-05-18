using Ecommerce.Domain.Models;
using Ecommerce.Service.ViewModels.ProductDetail;
using EcommerceCommon.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Interface
{
    public interface IProductSizeService : IServices<ProductSize>
    {
        Task<IList<ProductSizeViewModel>> GetProductSizeByProductId(Guid ProductId);
    }
}
