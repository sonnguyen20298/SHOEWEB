using Ecommerce.Domain.Models;
using Ecommerce.Service.ViewModels.ProductDetail;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Interface
{
    public interface IProductImageService :IServices<ProductImage>
    {
        Task<IList<ProductImageViewModel>> GetProductImageByProductId(Guid ProductId);
    }
}
