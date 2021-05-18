using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.Domain.Models;
using Ecommerce.Repository;
using Ecommerce.Repository.Interfaces;
using Ecommerce.Service.Interface;
using Ecommerce.Service.ViewModels;
using Ecommerce.Service.ViewModels.Homepage;
using Ecommerce.Service.ViewModels.ProductDetail;
using EcommerceCommon.Infrastructure.ViewModel;

namespace Ecommerce.Service.Services
{
    public class ProductService : EcommerceServices<Product>, IProductService
    {
        private readonly IProductReponsitory _productReponsitory;
        private readonly IMapper _mapper;

        public ProductService(IProductReponsitory productReponsitory, IMapper mapper) : base(productReponsitory)
        {
            _productReponsitory = productReponsitory;
            _mapper = mapper;
            this._productReponsitory = productReponsitory;
        }

        public Task<List<ProductHomepage>> GetHotTrendProduct()
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductHomepage>> GetProductTopView()
        {
            var product = await _productReponsitory.GetProductTopView();
            return product;

        }


        public async Task<List<ProductListViewModel>> GetProductByCategoryLevel2(Guid CategoryId)
        {
            var product = await _productReponsitory.GetProductByCategoryLevel2(CategoryId);
            return product;
        }        
        public async Task<List<ProductListViewModel>> GetProductByCategoryLevel1(Guid CategoryId)
        {
            var product = await _productReponsitory.GetProductByCategoryLevel1(CategoryId);
            return product;
        }

        public async Task<ProductViewModel> GetProductByProductId(Guid ProductId)
        {
            var product = await _productReponsitory.GetByIdAsync(ProductId);
            return _mapper.Map<ProductViewModel>(product);
        }
    }
}
