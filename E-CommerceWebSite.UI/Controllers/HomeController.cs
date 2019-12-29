using E_CommerceWebSite.Services;
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
            return View(products);
        }
    }
}