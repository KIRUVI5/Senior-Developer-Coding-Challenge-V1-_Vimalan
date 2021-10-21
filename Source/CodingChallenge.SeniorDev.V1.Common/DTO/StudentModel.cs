using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Common.DTO
{
    public class StudentModel
    {
        public Guid ID { get; set; }

        public string RegistrationID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTimeOffset Birthdate { get; set; }

        public string Email { get; set; }

        public string NICNo { get; set; }

    }
}
