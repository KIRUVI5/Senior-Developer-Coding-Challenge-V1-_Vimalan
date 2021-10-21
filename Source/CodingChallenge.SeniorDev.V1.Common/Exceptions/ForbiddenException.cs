using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Common.Exceptions
{
    /// <summary>
    /// Custom exception largely for handling HTTP 403 errors
    /// </summary>
    public class ForbiddenException : Exception
    {
        public ForbiddenException(string message) : base(message) { }
    }
}
