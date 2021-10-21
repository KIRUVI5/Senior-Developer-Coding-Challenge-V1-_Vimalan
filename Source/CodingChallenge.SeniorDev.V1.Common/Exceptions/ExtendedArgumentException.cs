using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Common.Exceptions
{

    /// <summary>
    /// Custom argument exception can take extra details for error reporting in ExceptionMiddleware
    /// </summary>
    public class ExtendedArgumentException : Exception
    {
        public ExtendedArgumentException(string message, object extraInfo) : base(message)
        {
            ExtraInfo = extraInfo;
        }

        /// <summary>
        /// These details are used in the ExceptionMiddleware to fill in the ExtraInfo field of APIError
        /// </summary>
        public object ExtraInfo { get; set; }
    }
}
