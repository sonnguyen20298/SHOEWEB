using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Service.Interface;
using Ecommerce.Service.ViewModels.ProductList;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Web.Controllers
{
    public class ProductListController : Controller
    {
        // GET: ProductListController
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IManufacturerService _manufacturerService;
        public ProductListController(ICategoryService categoryService, IProductService productService, IManufacturerService manufacturerService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _manufacturerService = manufacturerService;
        }
        public async Task<IActionResult> GetProductByCategoryLevel2(Guid ID)
        {
            ViewBag.Categories = await _categoryService.GetCategoryMenuHomepage();
            ViewBag.CategoriesLevel2 = await _categoryService.GetCategoryLever2();
            ViewBag.Manufacturer = await _manufacturerService.GetManufacturerHomepage();
            ViewBag.Products = await _productService.GetProductByCategoryLevel2(ID);
            ViewBag.CategoriesProductList = await _categoryService.GetCategoryProductList(ID);
            //var products = await _productService.GetProductByCategoryLevel2(ID);
            //var categories = await _categoryService.GetCategoryProductList(ID);
            //var models = new ProductListModel()
            //{
            //    ProductListViewModel =products,
            //    CategoryProductListViewModel = categories
            //};
            return View();
        }        
        public async Task<IActionResult> GetProductByCategoryLevel1(Guid ID)
        {
            ViewBag.Categories = await _categoryService.GetCategoryMenuHomepage();
            ViewBag.Manufacturer = await _manufacturerService.GetManufacturerHomepage();
            ViewBag.CategoriesLevel2 = await _categoryService.GetCategoryLever2();
            ViewBag.Products = await _productService.GetProductByCategoryLevel1(ID);
            ViewBag.CategoriesProductList = await _categoryService.GetCategoryProductList(ID);
            //var products = await _productService.GetProductByCategoryLevel1(ID);
            //var categoriesProductList = await _categoryService.GetCategoryProductList(ID);
            //var models = new ProductListModel()
            //{
            //    ProductListViewModel =products,
            //    CategoryProductListViewModel = categoriesProductList,
            //};
            return View();
        }

    }
}
