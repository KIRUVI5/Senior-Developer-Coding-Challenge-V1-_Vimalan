using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Common.Exceptions
{
    /// <summary>
    /// Custom exception largely for handling HTTP 409 errors
    /// </summary>
    public class AlreadyExistsException : Exception
    {
        public AlreadyExistsException(string message) : base(message) { }
    }
}
