using CodingChallenge.SeniorDev.V1.Common.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CodingChallenge.SeniorDev.V1.Common.Configuration
{
    public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourses>
    {
        public void Configure(EntityTypeBuilder<StudentCourses> builder)
        {
            builder.HasData
            (
               new StudentCourses() { StudentID = Guid.Parse("18fda881-da8c-4cb2-a929-b3b901c9909d"), CourseID = Guid.Parse("97600ec6-fb99-4e0e-a501-6e2ad0de3895") },
               new StudentCourses() { StudentID = Guid.Parse("709d37b5-685d-4afa-acda-4835c2cfef6d"), CourseID = Guid.Parse("6eced36f-0bcc-4b1e-9f46-1fefa0881cc6") }
            );
        }
    }
}
