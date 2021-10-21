using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodingChallenge.SeniorDev.V1.Common.Entity
{
    public class Student
    {
        public Guid ID { get; set; }

        public string RegistrationID { get; set; }

        [MaxLength(30)]
        public string FirstName { get; set; }

        [MaxLength(30)]
        public string LastName { get; set; }

        public DateTimeOffset Birthdate { get; set; }

        public string Email { get; set; }

        public string NICNo { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
