using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Common.Helper.Models
{
    public class ResponseResult<TResult>
    {
        public IEnumerable<string> Errors { get; set; }
        public required TResult Result { get; set; }
        public bool Succeeded { get; set; }

        public object Select(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
