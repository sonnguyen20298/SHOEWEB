using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Service.Interface;
using Ecommerce.Service.ViewModels.ProductDetail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Web.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IManufacturerService _manufacturerService;
        private readonly IProductSizeService _productSizeService;
        private readonly IProductImageService _productImageService;
        public ProductDetailController(ICategoryService categoryService, IProductService productService
            , IManufacturerService manufacturerService, IProductSizeService productSizeService, IProductImageService productImageService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _manufacturerService = manufacturerService;
            _productSizeService = productSizeService;
            _productImageService = productImageService;
        }
        public async Task<IActionResult> GetProductDetail(Guid ID)
        {
            ViewBag.Categories = await _categoryService.GetCategoryMenuHomepage();
            ViewBag.CategoriesLevel2 = await _categoryService.GetCategoryLever2();
            ViewBag.Products = await _productService.GetProductByProductId(ID);
            ViewBag.ProductSize = await _productSizeService.GetProductSizeByProductId(ID);
            ViewBag.ProductImage = await _productImageService.GetProductImageByProductId(ID);
            //var products = await _productService.GetProductByProductId(ID);
            //var productSize = await _productSizeService.GetProductSizeByProductId(ID);
            //var productImage = await _productImageService.GetProductImageByProductId(ID);
            //var models = new ProductDetailModel()
            //{
            //    ProductViewModel = products,
            //    ProductSizeViewModel =productSize,
            //    ProductImageViewModel =productImage,
            //};
            return View();
        }
    }
}