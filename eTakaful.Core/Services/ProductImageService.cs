using AutoMapper;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using Ecommerce.Service.Interface;
using Ecommerce.Service.ViewModels.ProductDetail;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Services
{
    public class ProductImageService : EcommerceServices<ProductImage>, IProductImageService
    {
        private readonly IProductImageRepository _productImageReponsitory;
        private readonly IMapper _mapper;


        public ProductImageService(IProductImageRepository productImageReponsitory, IMapper mapper) : base(productImageReponsitory)
        {
            _productImageReponsitory = productImageReponsitory;
            _mapper = mapper;
        }

        public async Task<IList<ProductImageViewModel>> GetProductImageByProductId(Guid ProductId)
        {
            var productImage = await _productImageReponsitory.FindAllAsync(x => x.IsDeleted == false && x.ProductId == ProductId);
            return _mapper.Map<List<ProductImageViewModel>>(productImage);
        }
    }
}
