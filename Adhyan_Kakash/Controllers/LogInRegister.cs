using Adhyan_Kakash.Models;
using Microsoft.AspNetCore.Mvc;
using Kaksh_Service;
using Student_DataAccess.StudentContext;
using Microsoft.EntityFrameworkCore;

namespace Adhyan_Kakash.Controllers
{
    public class LogInRegister : Controller
    {
        
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Registration(Student studentModel)
        {
            KakshServices kaksh = new KakshServices();
            kaksh.SaveData(studentModel);            
            return View();
        }
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(Student chkdata)
        {
            KakshServices kaksh = new KakshServices();
            kaksh.CheckData(chkdata);
            return RedirectToAction("AboutUs", "Home");
        }

    }
}