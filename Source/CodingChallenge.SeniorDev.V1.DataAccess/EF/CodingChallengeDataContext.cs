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
        }

        public Task<List<Course>> GetAllCourses()
            => Courses.Where(c => !c.IsDeleted).OrderBy(c => c.Title).AsNoTracking().ToListAsync();

        public Task<List<Teacher>> GetAllTeachers()
          => Teachers.Where(t => !t.IsDeleted).OrderBy(t => t.FirstName).AsNoTracking().ToListAsync();

        public Task<List<Student>> GetAllStudents()
         => Students.Where(t => !t.IsDeleted).OrderBy(t => t.FirstName).AsNoTracking().ToListAsync();


        public async Task<StudentCourses> EnrollToCourse(StudentCourses entity)
        {
            //TODO:Null Check
            Set<StudentCourses>().Add(entity);

            await SaveChangesAsync();

            return entity;
        }

        public async Task<Course> GetCourseById(Guid id)
        {
            //TODO:Dont take deleted
            return await Set<Course>().FindAsync(id);
        }

        public async Task<Student> GetStudentById(Guid id)
        {
            //TODO:Dont take deleted
            return await Set<Student>().FindAsync(id);
        }

        public async Task<StudentCourses> GetStudentCourseById(Guid id)
        {
            //TODO:Dont take deleted
            return await StudentCourses.Where(sc => sc.StudentID == id && !sc.IsDeleted).FirstOrDefaultAsync();
        }

        public async Task<Student> GetStudentByRegistrationId(string registrationID)
        {
            return await Students.Where(s => s.RegistrationID == registrationID && !s.IsDeleted).FirstOrDefaultAsync();
        }

        public async Task<Student> CreateStudent(Student entity)
        {
            //TODO:Null Check
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
