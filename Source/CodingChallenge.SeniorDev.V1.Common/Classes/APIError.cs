using CodingChallenge.SeniorDev.V1.Common.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Common.Classes
{
    public class APIError
    {
        public string Message { get; set; }

        /// <summary>
        /// Extra info returned to user - normally nothing
        /// </summary>
        public object ExtraInfo { get; set; }
        /// <summary>
        /// HTTP code
        /// </summary>
        public HttpStatusCode HTTPCode { get; set; }

        /// <summary>
        /// Name of exception thrown
        /// </summary>
        public string ExceptionName { get; set; }


        /// This is used when generating errors and directly writing to a string output
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, JsonSerializerSettingsExtensions.GetSerializerSettings());
        }

    }
}
