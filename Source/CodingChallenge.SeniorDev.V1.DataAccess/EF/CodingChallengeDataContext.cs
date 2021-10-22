using CodingChallenge.SeniorDev.V1.Common.Configuration;
using CodingChallenge.SeniorDev.V1.Common.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.DataAccess.EF
{
    public class CodingChallengeDataContext : DbContext
    {
        public CodingChallengeDataContext()
        {

        }
        public CodingChallengeDataContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<StudentCourses> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourses>().HasKey(sc => new
            {
               sc.StudentID,
               sc.CourseID
            });

            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherCongiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new StudentCourseConfiguration());

            modelBuilder.Entity<Student>()
                        .HasIndex(s => s.Email).IsUnique();

            modelBuilder.Entity<Student>()
                        .HasIndex(s => s.NICNo).IsUnique();

            modelBuilder.Entity<Teacher>()
                      .HasIndex(t => t.Email).IsUnique();
                        
        }

        public Task<List<Course>> GetAllCourses()
            => Courses.Where(c => !c.IsDeleted).OrderBy(c => c.Title).AsNoTracking().ToListAsync();

        public Task<List<Teacher>> GetAllTeachers()
          => Teachers.Where(t => !t.IsDeleted).OrderBy(t => t.FirstName).AsNoTracking().ToListAsync();

        public Task<List<Student>> GetAllStudents()
         => Students.Where(t => !t.IsDeleted).OrderBy(t => t.FirstName).AsNoTracking().ToListAsync();

        public async Task<Student> GetLastAddedStudent()
            => await Students.OrderByDescending(t => t.RegistrationID).FirstOrDefaultAsync();

        public async Task<Course> GetCourseById(Guid id)
           => await Courses.Where(c => !c.IsDeleted && c.ID == id).OrderBy(c => c.Title).FirstOrDefaultAsync();

        public async Task<Student> GetStudentById(Guid id)
          => await Students.Where(s => !s.IsDeleted && s.ID == id).OrderBy(c => c.FirstName).FirstOrDefaultAsync();

        public async Task<StudentCourses> GetStudentCourseById(Guid id)
         => await StudentCourses.Where(sc => sc.StudentID == id && !sc.IsDeleted).FirstOrDefaultAsync();

        public async Task<Student> GetStudentByRegistrationId(string registrationID)
            => await Students.Where(s => s.RegistrationID == registrationID && !s.IsDeleted).FirstOrDefaultAsync();
       
        public async Task<StudentCourses> EnrollToCourse(StudentCourses entity)
        {
            Set<StudentCourses>().Add(entity);

            await SaveChangesAsync();

            return entity;
        }

        public async Task<Student> CreateStudent(Student entity)
        {
            Set<Student>().Add(entity);

            await SaveChangesAsync();

            return entity;
        }

        public async Task<Student> UpdateStudent(Student entity)
        {
            Entry(entity).State = EntityState.Modified;

            await SaveChangesAsync();

            return entity;
        }

        public async Task<StudentCourses> UpdateStudentCourse(StudentCourses entity)
        {
            Entry(entity).State = EntityState.Modified;

            await SaveChangesAsync();

            return entity;
        }
    }
}
