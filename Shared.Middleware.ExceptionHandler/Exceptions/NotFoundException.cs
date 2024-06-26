using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Middleware.ExceptionHandler.Exceptions
{
    public class NotFoundException : Exception
    {
        /// <summary>
        /// Constructor NotFoundException
        /// </summary>
        public NotFoundException()
        {
        }

        /// <summary>
        /// Constructor NotFoundException
        /// </summary>
        /// <param name="message"></param>
        public NotFoundException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Constructor NotFoundException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public NotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
