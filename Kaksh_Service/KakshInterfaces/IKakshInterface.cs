using System.Collections.Generic;
using Student_DataAccess.StudentContext;

namespace Kaksh_Service.KakshInterfaces
{
   public interface IKakshInterface
    {
       public List<Course> FuncCourses();
        public List<Student> FuncStudents();
        public void SaveData(Student student);

        public string CheckData(Student student);
    }
}
