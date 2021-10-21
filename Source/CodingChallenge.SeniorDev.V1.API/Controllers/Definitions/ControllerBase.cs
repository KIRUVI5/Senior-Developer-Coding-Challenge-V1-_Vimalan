using AutoMapper;
using CodingChallenge.SeniorDev.V1.Common.Configuration;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CodingChallenge.SeniorDev.V1.API.Controllers.Definitions
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public abstract class BaseController : ControllerBase
    {
        protected readonly IMediator mediator;
        protected readonly IOptionsSnapshot<CodingChallengeConfiguration> configuration;
        protected readonly IMapper mapper;

        public BaseController(IMediator mediator, IOptionsSnapshot<CodingChallengeConfiguration> configuration, IMapper mapper) : base()
        {
            this.mediator = mediator;
            this.configuration = configuration;
            this.mapper = mapper;
        }

        public BaseController(IMediator mediator, IOptionsSnapshot<CodingChallengeConfiguration> configuration) : base()
        {
            this.mediator = mediator;
            this.configuration = configuration;
        }
    }
}
