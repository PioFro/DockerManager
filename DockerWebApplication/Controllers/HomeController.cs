using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DockerWebApplication.Models;

namespace DockerWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private User loggedUser;
        private User placeholderUser;
        [HttpPost]
        public ActionResult Login(User user)
        {
            var name = user.Name;
            var password = user.Password;
            User supposedlyLoggedUser;
            supposedlyLoggedUser = name.Contains("@") ? DataProvider.GetUserByEmail(name).Result[0] : DataProvider.GetUserByName(name).Result[0];

            if (supposedlyLoggedUser == null)
                return RedirectToAction("Login");
            
            if (supposedlyLoggedUser.Password != password)
                return RedirectToAction("Login");
            
            return RedirectToAction("Index");
        }
        public ActionResult Login()
        {
            placeholderUser = new User();
            this.placeholderUser.Name = "Login or email";
            this.placeholderUser.Password = "********";
            ViewBag.Message = "Login";
            return View(placeholderUser);
        }
        public ActionResult Index()
        {
            ViewBag.Message = "Please log in";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = DataProvider.GetUserByName("UserName1").Result[0].Name;
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}