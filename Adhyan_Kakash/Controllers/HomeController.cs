using Adhyan_Kakash.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Student_DataAccess.StudentContext;
using Kaksh_Service;

namespace Adhyan_Kakash.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentDBContext _studentDBContext;
        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //KakshServices _kakshServices = new KakshServices();
            //List<string> courseNames = _kakshServices.FuncCourses()
            //    .Select(x => x.CourseName)
            //    .ToList();

            //// Pass the course names to the view using ViewBag
            //ViewBag.CourseNames = courseNames;

            return View();
        }


        public IActionResult AboutUs()
        {
           return View();
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