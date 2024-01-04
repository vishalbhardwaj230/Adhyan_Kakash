using System.Collections.Generic;
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


    }
}
