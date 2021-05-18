using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Domain.Models;
using Ecommerce.Service.ViewModels.Homepage;
using Ecommerce.Service.ViewModels.ProductList;
using EcommerceCommon.Infrastructure.ViewModel;

namespace Ecommerce.Service.Interface
{
    public interface ICategoryService : IServices<Category>
    {
        //Task<ICollection<CategoryViewModel>> GetCategoryParrent();
        Task<IList<CategoryMenuHomepageViewModel>> GetCategoryMenuHomepage();
        Task<IList<CategoryMenuHomepageViewModel>> GetCategoryLever2();
        Task<IList<CollectionHomepage>> GetCollectionHomepage();
        Task<CategoryProductListViewModel> GetCategoryProductList(Guid CategoryID);
        

    }
}
