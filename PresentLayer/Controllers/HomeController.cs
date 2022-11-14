using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PresentLayer.Models;
using EntityLayer;

namespace PresentLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentService studentService;
        Student st;

        public HomeController(ILogger<HomeController> logger, IStudentService studentService)
        {
            _logger = logger;
            this.studentService = studentService;
        }

        public IActionResult Index()
        {
            var result = studentService.ListAllStudent();
            return View(result);
        }

        public IActionResult ListAll()
        {
            var result = studentService.ListAllStudent();
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
