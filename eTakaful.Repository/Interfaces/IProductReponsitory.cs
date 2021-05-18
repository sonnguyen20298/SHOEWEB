using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Domain.Models;
using EcommerceCommon.Infrastructure.ViewModel;

namespace Ecommerce.Repository.Interfaces
{
    public interface IProductReponsitory : IRepository<Product>
    {
        Task<List<ProductHomepage>> GetHotTrendProduct();
        Task<List<ProductHomepage>> GetProductTopView();
        Task<List<ProductListViewModel>> GetProductByCategoryLevel2(Guid CategoryId);
        Task<List<ProductListViewModel>> GetProductByCategoryLevel1(Guid CategoryId);
    } 
   
}
