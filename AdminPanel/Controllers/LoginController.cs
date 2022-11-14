using DataAccess.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AdminPanel.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GirisYap(User user)
        {
            var bilgi = c.Users.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);
            if (bilgi != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
    }
