using CodingChallenge.SeniorDev.V1.API.Controllers.Definitions;
using CodingChallenge.SeniorDev.V1.Business.Actions.Courses;
using CodingChallenge.SeniorDev.V1.Common.Configuration;
using CodingChallenge.SeniorDev.V1.Common.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.API.Controllers
{
    public class CoursesController : BaseController
    {
        public CoursesController(IMediator mediator, IOptionsSnapshot<CodingChallengeConfiguration> configuration)
            : base(mediator, configuration)
        {}

        /// <summary>
        /// Get all coursess
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("all")]
        public async Task<ActionResult<List<CourseModel>>> GetAll()
        {
            var result = await mediator.Send(new GetAllCoursesQuery());
            return Ok(result.CourseList);
        }

        /// <summary>
        /// Entroll to a course
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("enroll")]
        public async Task<ActionResult> EnrollToCourse(EnrollToCourseQuery request)
        {
            var result = await mediator.Send(request);

            return Ok(result);
        }
    }
}
