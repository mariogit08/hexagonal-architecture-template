using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using $safeprojectname$.Helper;

namespace  $safeprojectname$.Responses
{
    public class Response : IResponse
    {
        public ValidationMessage Message { get; internal set; }

        public bool Success { get; internal set; } = true;

        public static Response CreateResponse(ValidationMessage? message = null)
        {
            return new Response
            {
                Message = message ?? ValidationMessageHelper.Create(ValidationMessages.SUCCESSO),
                Success = true
            };
        }

        public static Response CreateErrorResponse(ValidationMessage message)
        {
            return new Response
            {
                Message = message,
                Success = false
            };
        }

        public static Response<T> CreateResponse<T>(T content, ValidationMessage? message = null)
        {
            var response = new Response<T>
            {
                Content = content,
                Success = true,
                Message = message ?? ValidationMessageHelper.Create(ValidationMessages.SUCCESSO)
            };

            return response;
        }

        public static Response<T> CreateErrorResponse<T>(ValidationMessage message, T content = default(T))
        {
            var response = new Response<T>
            {
                Content = content,
                Success = false,
                Message = message,
            };

            return response;
        }

       
    }

    public class Response<T> : Response, IResponse<T>
    {
        public T Content { get; set; }
    }
}

