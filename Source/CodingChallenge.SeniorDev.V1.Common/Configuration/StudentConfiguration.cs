using CodingChallenge.SeniorDev.V1.Common.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Common.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData
            (
                new Student { ID = Guid.Parse("e4f1d5c8-3c6b-469e-b584-4c9aeb7f4e6a"), RegistrationID = "ST001", FirstName = "Vimalan", LastName = "Kumarakulasingam", Birthdate = new DateTime(1991, 5, 26), Email = "kiruvi5@gmail.com", NICNo = "91781472325v", IsDeleted = false },
                new Student { ID = Guid.Parse("e3462baa-cda0-4c17-b02d-f5e28aab83f9"), RegistrationID = "ST002", FirstName = "hari", LastName = "Andrew", Birthdate = new DateTime(1992, 5, 26), Email = "Andrew@gmail.com", NICNo = "92147872325v", IsDeleted = false },
                new Student { ID = Guid.Parse("e6f6a7b4-463d-48ff-a7b2-9e680f5ffa0a"), RegistrationID = "ST003", FirstName = "nimal", LastName = "ilanko", Birthdate = new DateTime(1992, 5, 26), Email = "ilanko@gmail.com", NICNo = "93671472325v", IsDeleted = false },
                new Student { ID = Guid.Parse("36dca186-bd97-4da7-9a3f-877ba9b51c0b"), RegistrationID = "ST004", FirstName = "venkat", LastName = "mohan", Birthdate = new DateTime(1992, 5, 26), Email = "mohan@gmail.com", NICNo = "941478972325v", IsDeleted = false },
                new Student { ID = Guid.Parse("18fda881-da8c-4cb2-a929-b3b901c9909d"), RegistrationID = "ST005", FirstName = "raj", LastName = "theja", Birthdate = new DateTime(1992, 5, 26), Email = "theja@gmail.com", NICNo = "96146772325v", IsDeleted = false },
                new Student { ID = Guid.Parse("df3cedb1-23b4-4759-ac1e-b8237bc5c8d7"), RegistrationID = "ST006", FirstName = "karan", LastName = "shan", Birthdate = new DateTime(1992, 5, 26), Email = "shan@gmail.com", NICNo = "971454372325v", IsDeleted = false },
                new Student { ID = Guid.Parse("bc4e0df4-e6f9-486b-b2f2-4f436e51d777"), RegistrationID = "ST007", FirstName = "ravi", LastName = "asanka", Birthdate = new DateTime(1992, 5, 26), Email = "asanka@gmail.com", NICNo = "9561472325v", IsDeleted = false },
                new Student { ID = Guid.Parse("90217a07-92bc-428b-97c0-5fad0c7ef03c"), RegistrationID = "ST008", FirstName = "mathan", LastName = "nisan", Birthdate = new DateTime(1992, 5, 26), Email = "nisan@gmail.com", NICNo = "926781472325v", IsDeleted = false },
                new Student { ID = Guid.Parse("5391b718-784a-4c15-a72d-4c5a4c35a488"), RegistrationID = "ST009", FirstName = "juvi", LastName = "kannan", Birthdate = new DateTime(1992, 5, 26), Email = "kannan@gmail.com", NICNo = "95764621472325v", IsDeleted = false },
                new Student { ID = Guid.Parse("709d37b5-685d-4afa-acda-4835c2cfef6d"), RegistrationID = "ST0010", FirstName = "ari", LastName = "mohan", Birthdate = new DateTime(1992, 5, 26), Email = "ari@gmail.com", NICNo = "921897472325v", IsDeleted = false }
            );
        }
    }
}
