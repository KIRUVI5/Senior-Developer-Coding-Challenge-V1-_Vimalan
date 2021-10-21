using CodingChallenge.SeniorDev.V1.Common.Entity;
using Microsoft.EntityFrameworkCore;
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
        { }

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
        }

        public Task<List<Course>> GetAllCourses()
            => Courses.Where(c => !c.IsDeleted).OrderBy(c => c.Title).AsNoTracking().ToListAsync();
    }
}
