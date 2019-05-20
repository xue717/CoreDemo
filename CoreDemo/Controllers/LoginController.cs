using System;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using CoreDemo.Database.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Signin");
        }

        public IActionResult GoSignUp()
        {
            return View("Signup");
        }

        public IActionResult Login(Login login)
        {
            var dc = new CoreDemoContext();
            var query = dc.ULogin.Any(l => l.Name == login.Name && l.Password == login.Password);
            if (query)
            {
                ViewBag.LoginName = login.Name;
                return View("Views/Home/Index.cshtml");
            }
            return View("失败");
        }

        [HttpPost]
        public IActionResult SignUpName(string Name)
        {
            var dc = new CoreDemoContext();
            var query = dc.ULogin.Any(l => l.Name == Name);
            if (query)
                return Content("此用户名已被注册");
            else
                return Content("可以使用");
        }


        public IActionResult SignUp(string Name, string Password)
        {
            if (string.IsNullOrWhiteSpace(Name))
                return Content("用户名不可以为空");
            if (string.IsNullOrWhiteSpace(Password))
                return Content("密码不可以为空");
            if (Password.Length < 6)
                return Content("密码不可以小于六位");
            var dc = new CoreDemoContext();
            var query = dc.ULogin.Any(l => l.Name == Name);
            if (query)
                return Content("此用户名已被注册");
            var NewUser = new ULogin
            {
                Name = Name,
                Password = Password,
                CreateTime = DateTime.Now.Date,
                Enable = true
            };
            dc.ULogin.Add(NewUser);
            dc.SaveChanges();
            ViewBag.LoginName = Name;
            return View("SignupSuccess");
        }
    }

    public class Login
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
