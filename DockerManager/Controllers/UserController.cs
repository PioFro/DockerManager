using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerManager.Models;
using DockerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Entities;

namespace DockerManager.Controllers
{
    public class UserController : Controller
    {
        public static User LoginUser = new User();
        static bool WrongCredentials = false;
        public IActionResult Index()
        {
            if(WrongCredentials)
            {
                ViewBag.Message = "You provided wrong username and/or password";
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            try
            {
                LoginUser = DataProvider.GetUserByEmail(user.Email).Result[0];
                PasswordManager.SetKeys(user.Password, LoginUser.Name);
                string hash = PasswordManager.Encrypt(user.Password);
                if (LoginUser.Password == hash)
                {
                    PasswordManager.SetKeys("", "");
                    //match!
                    return View("AfterLogin", LoginUser);
                }
                else
                {
                    return View("WrongEmailOrPassword");
                }
               
            }
            catch { }

            return View("WrongEmailOrPassword");
        }
        public IActionResult AfterLogin(User user)
        {
            return View(LoginUser);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if(user.NotNull()&&DataProvider.CanCreateUser(user).Result)
            {
                PasswordManager.SetKeys(user.Password, user.Name);
                user.Password = PasswordManager.Encrypt(user.Password);
                PasswordManager.SetKeys("", "");
                user.SaveAsync();
                
                return View("Index");
            }
            return View("WrongInfo");
        }
        public IActionResult WrongInfo()
        {
            return View();
        }

        public IActionResult WrongEmailOrPassword()
        {
            return View();
        }
    }
}
