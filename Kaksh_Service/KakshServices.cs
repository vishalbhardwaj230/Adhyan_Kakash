using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;
using Kaksh_Service.KakshInterfaces;
using Student_DataAccess.StudentContext;

namespace Kaksh_Service
{
    public class KakshServices : IKakshInterface
    {
        


        public List<Course> FuncCourses()
        {
            StudentDBContext studentDBContext = new StudentDBContext();

            // Assuming Course is the entity in your context
            List<Course> courses = studentDBContext.Courses.ToList();

            return courses;
        }
        public List<Student> FuncStudents()
        {
            StudentDBContext studentDBContext = new StudentDBContext();

            // Assuming Course is the entity in your context
            List<Student> _students= studentDBContext.Students.ToList();

            return _students;
        }

        public void SaveData(Student student)
        {
            student.StudentId = GenerateRandomStudentId();
            StudentDBContext _studentDBContext = new StudentDBContext();
            _studentDBContext.Students.Add(student);
            _studentDBContext.SaveChanges();

        }
        private string GenerateRandomStudentId()
        {
            Random random = new Random();
            // Generating a random 6-digit student ID
            int randomId = random.Next(100000, 999999);
            return randomId.ToString();
        }

        public string CheckData(Student student)
        {
            string message="";
            StudentDBContext studentdata = new StudentDBContext();
             var user = studentdata.Students.Where(x => x.StudentName == student.StudentName).FirstOrDefault();
                if (user != null)
                {
                    if (user.Password == student.Password)
                    {
                    message = "Logged In Successfuly";
                    }
                }

            return $"Vishal {message}";
        }

    }
}
