﻿using AutoMapper;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using Ecommerce.Service.Interface;
using Ecommerce.Service.ViewModels.ProductDetail;
using EcommerceCommon.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Services
{
    public class ProductSizeService : EcommerceServices<ProductSize>, IProductSizeService
    {
        private readonly IProductSizeRepository _productSizeReponsitory;
        private readonly IMapper _mapper;


        public ProductSizeService(IProductSizeRepository productSizeReponsitory, IMapper mapper) : base(productSizeReponsitory)
        {
            _productSizeReponsitory = productSizeReponsitory;
            _mapper = mapper;
        }

        public async Task<IList<ProductSizeViewModel>> GetProductSizeByProductId(Guid ProductId)
        {
            var productSize = await _productSizeReponsitory.GetProductSizeByProductId(ProductId);
            return _mapper.Map<IList<ProductSizeViewModel>>(productSize);
        }
    }
}
