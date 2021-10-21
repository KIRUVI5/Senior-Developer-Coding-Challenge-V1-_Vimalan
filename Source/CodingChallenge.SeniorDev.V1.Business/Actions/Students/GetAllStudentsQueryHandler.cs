using AutoMapper;
using CodingChallenge.SeniorDev.V1.Common.DTO;
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
    public class GetAllStudentsQuery : IRequest<GetAllStudentsQuerResult>
    {

    }

    public class GetAllStudentsQuerResult
    {
        public List<StudentModel> StudentList { get; set; }
    }
    public class GetAllStudentsQueryHandler : IRequestHandler<GetAllStudentsQuery, GetAllStudentsQuerResult>
    {
        private readonly CodingChallengeDataContext dataContext;
        private readonly IMapper mapper;

        public GetAllStudentsQueryHandler(CodingChallengeDataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }

        public async Task<GetAllStudentsQuerResult> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            var students = await dataContext.GetAllStudents();

            return new GetAllStudentsQuerResult
            {
                StudentList = mapper.Map<List<StudentModel>>(students)
            };
        }

    }
}
