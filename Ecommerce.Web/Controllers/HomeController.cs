using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ecommerce.Web.Models;
using Ecommerce.Service.Interface;
using Ecommerce.Service.Services;
using Ecommerce.Service.ViewModels.Homepage;
using Ecommerce.Service.Dto;

namespace Ecommerce.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IManufacturerService _manufacturerService;
        

        public HomeController(ICategoryService categoryService, IProductService productService, IManufacturerService manufacturerService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _manufacturerService = manufacturerService;
        }

        public async Task<IActionResult> Index()
        {
            //var categories = await _categoryService.GetCategoryMenuHomepage();
            //var categoriesLevel2 = await _categoryService.GetCategoryLever2();
            //var manufacturer = await _manufacturerService.GetManufacturerHomepage();
            //var collections = await _categoryService.GetCollectionHomepage();
            //var products = await _productService.GetProductTopView();
            ViewBag.Categories = await _categoryService.GetCategoryMenuHomepage();
            ViewBag.Manufacturer = await _manufacturerService.GetManufacturerHomepage();
            ViewBag.CategoriesLevel2 = await _categoryService.GetCategoryLever2();
            ViewBag.ProductTopView = await _productService.GetProductTopView();
            ViewBag.CollectionHomepage = await _categoryService.GetCollectionHomepage();

            //var models = new HomepageModel()
            //{
            //    ProductHomepage = products,
            //    CollectionHompageViewModel = collections,
            //};

            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
