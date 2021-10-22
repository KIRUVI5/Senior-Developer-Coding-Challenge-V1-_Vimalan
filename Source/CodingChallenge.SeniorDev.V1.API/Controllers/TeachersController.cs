using CodingChallenge.SeniorDev.V1.API.Controllers.Definitions;
using CodingChallenge.SeniorDev.V1.Business.Actions.Teachers;
using CodingChallenge.SeniorDev.V1.Common.Configuration;
using CodingChallenge.SeniorDev.V1.Common.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.API.Controllers
{
    public class TeachersController : BaseController
    {
        public TeachersController(IMediator mediator, IOptionsSnapshot<CodingChallengeConfiguration> configuration)
            : base(mediator, configuration)
        { }

        /// <summary>
        /// Get all teachers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("all")]
        public async Task<ActionResult<List<TeacherModel>>> GetAll()
        {
            var result = await mediator.Send(new GetAllTeachersQuery());
            return Ok(result.TeacherList);
        }
    }
}
