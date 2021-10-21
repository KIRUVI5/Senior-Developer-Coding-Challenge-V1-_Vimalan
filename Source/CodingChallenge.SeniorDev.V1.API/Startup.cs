using CodingChallenge.SeniorDev.V1.API.AM;
using CodingChallenge.SeniorDev.V1.Business.Actions.Courses;
using CodingChallenge.SeniorDev.V1.Common.Classes;
using CodingChallenge.SeniorDev.V1.Common.Configuration;
using CodingChallenge.SeniorDev.V1.Common.Middleware;
using CodingChallenge.SeniorDev.V1.DataAccess.EF;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using System.Linq;
using System.Net;

namespace CodingChallenge.SeniorDev.V1.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CodingChallengeConfiguration>(Configuration);

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CodingChallenge - Senior Developers", Version = "v1" });
            });

            //================exception handling - when model validation fails==============
            services.AddControllers().ConfigureApiBehaviorOptions(options =>
            {
                options.InvalidModelStateResponseFactory = context =>
                {
                    // var result = new BadRequestObjectResult(context.ModelState);
                    var errors = context.ModelState
                        .Where(e => e.Value.Errors.Count > 0)
                        .Select(e => new APIError
                        {
                            HTTPCode = HttpStatusCode.BadRequest,
                            Message = e.Value.Errors.First().ErrorMessage
                        }).ToList();

                    var apiErrorsObj = new APIErrors();
                    apiErrorsObj.errors = errors;
                    return new BadRequestObjectResult(apiErrorsObj); ;
                };
            });

            // Adding MediatR
            services.AddMediatR(typeof(GetAllCoursesQueryHandler));

            // Adding AutoMapper
            services.AddAutoMapper(
                typeof(AutoMapperProfile)
            );

            services.AddDbContext<CodingChallengeDataContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString(ConnectionStringKeys.CodingChallengeDB)));

            services.Add(ServiceDescriptor.Singleton(typeof(IOptionsSnapshot<>), typeof(OptionsManager<>)));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CodingChallenge - Senior Developers"));
            }

            app.UseMiddleware<ExceptionMiddleware>();

            // ========http status such as 404 will not occur above so catch here============
            app.UseStatusCodePages(async context =>
            {
                await ExceptionMiddleware.HandleErrorsAsync(context.HttpContext, null, (HttpStatusCode)context.HttpContext.Response.StatusCode);
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

    public static class ConnectionStringKeys
    {
        public const string CodingChallengeDB = "CodingChallengeDb";
    }
}
