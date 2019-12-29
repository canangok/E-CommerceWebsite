
using E_CommerceWebSite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_CommerceWebSite.UI.Controllers
{
    public class LoginController : Controller
    {
        private static List<User> users;

        public LoginController()
        {
            if (users == null)
            {
                users = new List<User>()
                {
                    new User{Id=1,Email="Ümit",Password="123"},
                    new User{Id=2,Email="İrem",Password="123"},
                    new User{Id=3,Email="Değişken",Password="123"},
                    new User{Id=3,Email="Erkan",Password="123"},
                };
            }
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public ActionResult SignUp()
        //{
        //    return Content("SignUp");

        //}


        [HttpPost]
        [NonAction]
        public ActionResult AddUser(User User)
        {
            var user = new User
            {
                Id = users.Count + 1,
                Email = User.Email,
                Password = User.Password
            };

            users.Add(user);

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "İçeriği düzenleyebilmek için gerekli tüm alanları doldurmanız gerekmektedir");
                return RedirectToAction("Index");
            }

            return Content("Kayıt Başarılı");
            // return RedirectToAction("Index");
            // return Json(users, JsonRequestBehavior.AllowGet);
         }

        public ActionResult GetUser(User User)
        {
            return Json(users, JsonRequestBehavior.AllowGet);
        }

    }
}