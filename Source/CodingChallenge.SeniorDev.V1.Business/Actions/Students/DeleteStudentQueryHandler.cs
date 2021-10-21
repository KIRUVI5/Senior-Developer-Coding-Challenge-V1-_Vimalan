using AutoMapper;
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
    public class DeleteStudentQuery : IRequest<DeleteStudentQueryResult>
    {
        public List<string> IDList { get; set; }
    }

    public class DeleteStudentQueryResult
    {
        public List<Guid> IDList { get; set; }
    }

    public class DeleteStudentQueryHandler : IRequestHandler<DeleteStudentQuery, DeleteStudentQueryResult>
    {
        private readonly CodingChallengeDataContext dataContext;
        private readonly IMapper mapper;

        public DeleteStudentQueryHandler(CodingChallengeDataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }



        public async Task<DeleteStudentQueryResult> Handle(DeleteStudentQuery request, CancellationToken cancellationToken)
        {
            List<Guid> iDList = null;

            foreach (var registrationID in request.IDList)
            {
                iDList = new List<Guid>();

                Student studentObj = await dataContext.GetStudentByRegistrationId(registrationID);

                if (studentObj != null)
                {
                    studentObj.IsDeleted = true;

                    await dataContext.UpdateStudent(studentObj);

                    var studentCourseObj = await dataContext.GetStudentCourseById(studentObj.ID);

                    if (studentCourseObj != null)
                    {
                        studentCourseObj.IsDeleted = true;

                        await dataContext.UpdateStudentCourse(studentCourseObj);
                    }


                    iDList.Add(studentObj.ID);
                }
                
            }

            return new DeleteStudentQueryResult
            {
                IDList = iDList
            };
        }
    }
}
