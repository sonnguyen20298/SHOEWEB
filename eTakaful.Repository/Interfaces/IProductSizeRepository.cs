using Ecommerce.Domain.Models;
using EcommerceCommon.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository.Interfaces
{
    public interface IProductSizeRepository: IRepository<ProductSize>
    {
        Task<List<ProductSizeViewModel>> GetProductSizeByProductId(Guid ProductId);
    }
}
