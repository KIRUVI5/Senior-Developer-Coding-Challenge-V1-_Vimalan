using CodingChallenge.SeniorDev.V1.Common.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CodingChallenge.SeniorDev.V1.Common.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData
            (
               new Course() { ID = Guid.Parse("97600ec6-fb99-4e0e-a501-6e2ad0de3895"), Title = "Computer Science", Description = "Computer Science", TeacherID = Guid.Parse("f55d4e5c-0636-43e1-a770-2e8f170b0500"), Subject = "AI", MaximumStudentLimit = 15, IsDeleted = false },
               new Course() { ID = Guid.Parse("6eced36f-0bcc-4b1e-9f46-1fefa0881cc6"), Title = "Physical Science", Description = "Physical Science", TeacherID = Guid.Parse("5db11e34-33ee-4c48-9537-b1e56f33ca01"), Subject = "Engineering Drawing", MaximumStudentLimit = 15, IsDeleted = false }
            );
        }
    }
}
