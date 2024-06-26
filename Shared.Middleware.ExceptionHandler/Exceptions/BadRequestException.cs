using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Middleware.ExceptionHandler.Exceptions
{
    public class BadRequestException : Exception
    {
        /// <summary>
        /// Default Constructor BadRequestException
        /// </summary>
        public BadRequestException()
        {
        }
        /// <summary>
        /// Constructor BadRequestException
        /// </summary>
        /// <param name="message"></param>
        public BadRequestException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Constructor BadRequestException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public BadRequestException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
