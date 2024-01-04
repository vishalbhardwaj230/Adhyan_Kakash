using System;
using System.Collections.Generic;

namespace Student_DataAccess.StudentContext
{
    public partial class Vlink
    {
        public string VideoId { get; set; } = null!;
        public string? SubjectId { get; set; }
        public string? CourseId { get; set; }
        public string? Link { get; set; }

        public virtual Course? Course { get; set; }
        public virtual Subject? Subject { get; set; }
    }
}
