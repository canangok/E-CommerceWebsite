using E_CommerceWebSite.Services;
using E_CommerceWebSite.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_CommerceWebSite.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;

        public HomeController()
        {
            _productService = new ProductService();
            _categoryService = new CategoryService();

        }
        // GET: Home
        public ActionResult Index()
        {
            var products = _productService.GetProducts();
            var categories = _categoryService.GetCategories();

            var viewModel = new HomeIndexViewModel
            {
                Products = products,
                Categories = categories
            };

            return View(viewModel);
        }
        //HomeController
        //[NonAction]
        [ChildActionOnly]
        public ActionResult Test()
        {
            //var categories = _categoryService.GetTopCategories();
            var categories = _categoryService.GetCategories();
            return PartialView("_NavbarMenu", model: categories);
            //return PartialView("_");
        }
    }
}