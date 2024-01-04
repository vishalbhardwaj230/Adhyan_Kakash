using System.Collections.Generic;
using Student_DataAccess.StudentContext;

namespace Kaksh_Service.KakshInterfaces
{
   public interface IKakshInterface
    {
        List<Course> FuncCourses();
        List<Student> FuncStudents();
    }
}
