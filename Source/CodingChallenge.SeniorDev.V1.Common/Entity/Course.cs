using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingChallenge.SeniorDev.V1.Common.Entity
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Guid TeacherID { get; set; }

        public string Subject { get; set; }

        public int MaximumStudentLimit { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<StudentCourses> StudentCourses { get; set; }

    }
}
