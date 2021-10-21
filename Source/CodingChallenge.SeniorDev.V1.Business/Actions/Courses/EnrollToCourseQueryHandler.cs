using AutoMapper;
using CodingChallenge.SeniorDev.V1.Common.DTO;
using CodingChallenge.SeniorDev.V1.Common.Entity;
using CodingChallenge.SeniorDev.V1.Common.Exceptions;
using CodingChallenge.SeniorDev.V1.DataAccess.EF;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Business.Actions.Courses
{
    public class EnrollToCourseQuery : IRequest<EnrollToCourseQueryResult>
    {
        public Guid StudentID { get; set; }

        public Guid CourseID { get; set; }
    }


    public class EnrollToCourseQueryResult
    {
        public CourseModel Course { get; set; }
    }


    public class EnrollToCourseQueryHandler : IRequestHandler<EnrollToCourseQuery, EnrollToCourseQueryResult>
    {
        private readonly CodingChallengeDataContext dataContext;
        private readonly IMapper mapper;

        public EnrollToCourseQueryHandler(CodingChallengeDataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }



        public async Task<EnrollToCourseQueryResult> Handle(EnrollToCourseQuery request, CancellationToken cancellationToken)
        {
            //check validation for request

            var course = await dataContext.GetCourseById(request.CourseID);

            if (course == null)
                throw new NotFoundException($"Can't find the course for {request.CourseID}");

            var student = await dataContext.GetStudentById(request.StudentID);

            if (student == null)
                throw new NotFoundException($"Can't find the student for {request.StudentID}");


            //TODO :Null check
            StudentCourses requestObj = mapper.Map<StudentCourses>(request);

            var studentEntrolment = await dataContext.EnrollToCourse(requestObj);

            //TODO:validation student and course

            var entrolledCourse = await dataContext.GetCourseById(studentEntrolment.CourseID);           

            return new EnrollToCourseQueryResult
            {
                Course = mapper.Map<CourseModel>(entrolledCourse)
            };

        }
    }
}
