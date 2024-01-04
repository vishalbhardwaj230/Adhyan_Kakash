using System;
using System.Collections.Generic;

namespace Student_DataAccess.StudentContext
{
    public partial class Subject
    {
        public Subject()
        {
            Vlinks = new HashSet<Vlink>();
        }

        public string SubjectId { get; set; } = null!;
        public string? CourseId { get; set; }
        public string? CourseName { get; set; }

        public virtual Course? Course { get; set; }
        public virtual ICollection<Vlink> Vlinks { get; set; }
    }
}
