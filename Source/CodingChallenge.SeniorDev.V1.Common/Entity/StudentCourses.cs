using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingChallenge.SeniorDev.V1.Common.Entity
{
    public class StudentCourses
    {
        public Guid StudentID { get; set; }

        public Guid CourseID { get; set; }

        public bool IsDeleted { get; set; }
    }
}
