using System;
using System.Collections.Generic;

namespace Student_DataAccess.StudentContext
{
    public partial class Course
    {
        public Course()
        {
            Subjects = new HashSet<Subject>();
            Vlinks = new HashSet<Vlink>();
        }

        public string CourseId { get; set; } = null!;
        public string? CourseName { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Vlink> Vlinks { get; set; }
    }
}
