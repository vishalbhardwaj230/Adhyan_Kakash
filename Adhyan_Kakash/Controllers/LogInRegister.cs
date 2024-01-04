using Adhyan_Kakash.Models;
using Microsoft.AspNetCore.Mvc;
using Kaksh_Service;
using Student_DataAccess.StudentContext;
using Microsoft.EntityFrameworkCore;

namespace Adhyan_Kakash.Controllers
{
    public class LogInRegister : Controller
    {
        private readonly KakshServices _KakshServices;
        
        
        
        [HttpGet]

        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(StudentModel studentModel)
        {
        StudentDBContext _studentDBContext = new StudentDBContext();
            Student student = new Student();
            {
                student.StudentId = "224";
                student.StudentName = studentModel.Stname;
                student.FatherName = studentModel.FaName;
                student.Password = studentModel.Pass;
                student.Mail = studentModel.Email;
                student.Phone = studentModel.Phone;

            }
            _studentDBContext.Students.Add(student);
            _studentDBContext.SaveChanges();
            
            return View();
        }
        [HttpGet]
        public IActionResult LogIn()
        {
           

            return View();
        }

        [HttpPost]
        public IActionResult LogIn(string sname, string pass)
        {
            StudentDBContext context = new StudentDBContext();
            if (ModelState.IsValid)

            {
                var user = context.Students.Where(x => x.StudentName == sname).FirstOrDefault();
                if (user != null)
                {
                    if (user.Password == pass)
                    {
                        // Set the user's email in the session.
                        return RedirectToAction("AboutUs", "Home");

                    }

                }
            }
            return RedirectToAction("AboutUs", "Home");
        }

    }
}