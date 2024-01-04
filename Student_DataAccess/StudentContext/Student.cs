using System;
using System.Collections.Generic;

namespace Student_DataAccess.StudentContext
{
    public partial class Student
    {
        public string StudentId { get; set; } = null!;
        public string? StudentName { get; set; }
        public string? FatherName { get; set; }
        public long? Phone { get; set; }
        public string? Mail { get; set; }
        public string? Password { get; set; }
    }
}
