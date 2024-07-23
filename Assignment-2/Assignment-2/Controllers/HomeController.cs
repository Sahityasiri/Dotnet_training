using Assignment_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()

        {
            Student[] students = new Student[3]; 
            students[0] = new Student()
            {
                StudentId = 101,
                StudentName = "Siri",
                Age = 20,
                Marks = 98
            };
            students[1] = new Student()
            {
                StudentId = 102,
                StudentName = "Geetha",
                Age = 22,
                Marks = 99
            };
            students[2] = new Student()
            {
                StudentId = 103,
                StudentName = "Pradeepthi",
                Age = 21,
                Marks = 97
            };
            
            return View(students);
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
