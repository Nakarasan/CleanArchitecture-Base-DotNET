using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Middleware.ExceptionHandler.Exceptions
{
    public class ForbiddenException : Exception
    {
        /// <summary>
        /// Constructor ForbiddenException
        /// </summary>
        public ForbiddenException()
        {
        }

        /// <summary>
        /// Constructor ForbiddenException
        /// </summary>
        /// <param name="message"></param>
        public ForbiddenException(string message) : base(message)
        {
        }

        /// <summary>
        /// Constructor ForbiddenException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ForbiddenException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Constructor ForbiddenException
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected ForbiddenException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
