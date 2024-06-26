using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Middleware.ExceptionHandler.Exceptions
{
    public class BusinessLogicException : BadRequestException
    {
        /// <summary>
        /// Default Constructor BusinessLogicException
        /// </summary>
        public BusinessLogicException()
        {
        }

        /// <summary>
        /// Constructor BusinessLogicException
        /// </summary>
        /// <param name="message"></param>
        public BusinessLogicException(string message)
            : base(message)
        {
        }
        /// <summary>
        /// Constructor BusinessLogicException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public BusinessLogicException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
