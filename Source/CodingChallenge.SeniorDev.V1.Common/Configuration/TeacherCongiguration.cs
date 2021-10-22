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
    public class TeacherCongiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData
            (
              new Teacher{ ID = Guid.Parse("f55d4e5c-0636-43e1-a770-2e8f170b0500"), FirstName = "Mano", LastName = "Raj", Birthdate = new DateTime(1981, 5, 26), Email = "Mano@gmail.com", IsDeleted = false },
              new Teacher() { ID = Guid.Parse("5db11e34-33ee-4c48-9537-b1e56f33ca01"), FirstName = "Ragu", LastName = "Paramesh", Birthdate = new DateTime(1985, 5, 26), Email = "Ragu@gmail.com", IsDeleted = false }

            );
        }
    }
}
