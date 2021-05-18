using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Service.Dto;
using Ecommerce.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IManufacturerService _manufacturerService;
        private readonly IUserService _userService;
        private readonly IUserProfileService _userProfileService;
        public LoginController(ICategoryService categoryService, IProductService productService, IManufacturerService manufacturerService
            , IUserService userService, IUserProfileService userProfileService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _manufacturerService = manufacturerService;
            _userService = userService;
            _userProfileService = userProfileService;
        }
        public async Task<IActionResult> Register(UserDto userDto)
        {
            await _userService.Register(userDto);
            return RedirectToAction("Index","Home");
        }
        public async Task<IActionResult> Login(string UserName,string Password)
        {
            var user = await _userService.Login(UserName, Password);
            return RedirectToAction("Index", "Home");

        }

    }
}
