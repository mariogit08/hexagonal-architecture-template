using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  $safeprojectname$.Responses
{
    public interface IResponse
    {
        bool Success { get; }
        ValidationMessage Message { get; }
    }
    public interface IResponse<T> : IResponse
    {
        T Content { get; set; }
    }
}
