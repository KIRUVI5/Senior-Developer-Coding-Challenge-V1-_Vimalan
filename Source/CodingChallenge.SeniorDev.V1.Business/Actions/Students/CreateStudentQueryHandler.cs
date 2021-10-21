using AutoMapper;
using CodingChallenge.SeniorDev.V1.Common.DTO;
using CodingChallenge.SeniorDev.V1.Common.Entity;
using CodingChallenge.SeniorDev.V1.DataAccess.EF;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Business.Actions.Students
{
    public class CreateStudentQuery : IRequest<CreateStudentQueryResult>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTimeOffset Birthdate { get; set; }

        public string Email { get; set; }

        public string NICNo { get; set; }
    }

    public class CreateStudentQueryResult
    {
        public StudentModel Student { get; set; }
    }


    public class CreateStudentQueryHandler : IRequestHandler<CreateStudentQuery, CreateStudentQueryResult>
    {
        private readonly CodingChallengeDataContext dataContext;
        private readonly IMapper mapper;

        public CreateStudentQueryHandler(CodingChallengeDataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }



        public async Task<CreateStudentQueryResult> Handle(CreateStudentQuery request, CancellationToken cancellationToken)
        {
            //check validation for request

            //var course = await dataContext.GetCourseById(request.CourseID);

            //var student = await dataContext.GetStudentById(request.StudentID);


            //TODO :Null check
            Student requestObj = mapper.Map<Student>(request);

            var student = await dataContext.CreateStudent(requestObj);

            

            return new CreateStudentQueryResult
            {
                Student = mapper.Map<StudentModel>(student)
            };

        }
    }
}

