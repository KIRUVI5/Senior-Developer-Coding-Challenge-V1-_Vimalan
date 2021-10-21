using AutoMapper;
using CodingChallenge.SeniorDev.V1.API.Controllers.Definitions;
using CodingChallenge.SeniorDev.V1.Business.Actions.Students;
using CodingChallenge.SeniorDev.V1.Common.Configuration;
using CodingChallenge.SeniorDev.V1.Common.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.API.Controllers
{
    public class StudentsController : BaseController
    {
        public StudentsController(IMediator mediator, IOptionsSnapshot<CodingChallengeConfiguration> configuration, IMapper mapper)
            : base(mediator, configuration, mapper)
        { }

        [HttpGet]
        [Route("all")]
        public async Task<ActionResult<List<StudentModel>>> GetAll()
        {
            var result = await mediator.Send(new GetAllStudentsQuery());
            return Ok(result.StudentList);
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<StudentModel>> Create(StudentCreateModel request)
        {
            CreateStudentQuery requestObj = mapper.Map<CreateStudentQuery>(request);

            var result = await mediator.Send(requestObj);

            return Ok(result);
        }

        [HttpPut]
        [Route("delete")]
        public async Task<ActionResult<List<string>>> Delete(StudentDeleteModel request)
        {
            DeleteStudentQuery requestObj = mapper.Map<DeleteStudentQuery>(request);

            var result = await mediator.Send(requestObj);

            return Ok(result);
        }
    }
}
