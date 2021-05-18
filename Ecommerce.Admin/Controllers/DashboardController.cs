using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Admin.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public async Task<IActionResult> Index()
        {
            return View();
        }
        // GET: Dashboard

        public async Task<IActionResult> GetCategoryList()
        {
            return View();
        }
        public async Task<IActionResult> GetCollectionImage()
        {
            return View();
        }
        public async Task<IActionResult> GetProductList()
        {
            return View();
        }
        public async Task<IActionResult> GetProductComment()
        {
            return View();
        }
        public async Task<IActionResult> GetProductStatus()
        {
            return View();
        }
        public async Task<IActionResult> GetManufacturer()
        {
            return View();
        }
        public async Task<IActionResult> GetSupplier()
        {
            return View();
        }
        public async Task<IActionResult> GetOrderList()
        {
            return View();
        }
        public async Task<IActionResult> GetOrderHistory()
        {
            return View();
        }
        public async Task<IActionResult> GetCustomerList()
        {
            return View();
        }
        public async Task<IActionResult> GetStaffList()
        {
            return View();
        }
        public async Task<IActionResult> GetCoupon()
        {
            return View();
        }
        public async Task<IActionResult> GetStatisticsReport()
        {
            return View();
        }
        // GET: Dashboard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dashboard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dashboard/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Dashboard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dashboard/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Dashboard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dashboard/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}