using E_CommerceWebSite.Entities;
using E_CommerceWebSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_CommerceWebSite.UI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryService _categoryService;

        public CategoryController()
        {
            _categoryService = new CategoryService();
        }
        // GET: Admin/Category
        [HttpGet]
        public ActionResult Index()
        {
            var categories = _categoryService.GetCategories();
            return View(categories);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        //html de tokeni üretiyor burda doğruluyor
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Geçersiz Bilgi Girişi");
                return View(category);
            }
            _categoryService.Add(category);
            return RedirectToAction(nameof(Index)); 
        }

        [HttpGet]
        public ActionResult Detay(int id)
        {
            return View("Edit");
        }

    }
}