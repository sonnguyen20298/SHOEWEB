using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.Domain.Models;
using Ecommerce.Repository;
using Ecommerce.Repository.Interfaces;
using Ecommerce.Service.Interface;
using Ecommerce.Service.ViewModels;
using Ecommerce.Service.ViewModels.Homepage;
using Ecommerce.Service.ViewModels.ProductList;
using EcommerceCommon.Infrastructure.ViewModel;

namespace Ecommerce.Service.Services
{
    public class CategoryService : EcommerceServices<Category>, ICategoryService
    {
        private readonly ICategoryReponsitory _categoryReponsitory;        
        private readonly IMapper _mapper;

        public CategoryService(ICategoryReponsitory categoryReponsitory, IMapper mapper) : base(categoryReponsitory)
        {
            _categoryReponsitory = categoryReponsitory;           
            _mapper = mapper;
        }


        public async Task<IList<CategoryMenuHomepageViewModel>> GetCategoryLever2()
        {
            var category = await _categoryReponsitory.FindAllAsync(x => x.IsDeleted == false && x.ParentId !=null);
            return _mapper.Map<List<CategoryMenuHomepageViewModel>>(category);
        }

        public async Task<IList<CategoryMenuHomepageViewModel>> GetCategoryMenuHomepage()
        {
            var category = await _categoryReponsitory.FindAllAsync(x => x.IsDeleted == false && x.ParentId ==null);
            return _mapper.Map<List<CategoryMenuHomepageViewModel>>(category);

        }
 
        public async Task<ICollection<CategoryViewModel>> GetCategoryParrent()
        {
            var category = await _categoryReponsitory.GetCategoryParrent();
            return _mapper.Map<List<CategoryViewModel>>(category);
        }

        public async Task<CategoryProductListViewModel> GetCategoryProductList(Guid CategoryID)
        {
            var category = await _categoryReponsitory.GetByIdAsync(CategoryID);
            return _mapper.Map<CategoryProductListViewModel>(category);
        }

        public async Task<IList<CollectionHomepage>> GetCollectionHomepage()
        {
            var collections = await _categoryReponsitory.GetCollectionsHomepage();
            return collections;
        }
    }
}
