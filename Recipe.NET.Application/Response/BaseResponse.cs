using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.NET.Application.Response
{
    public class BaseResponse<T>
    {
        public ResponseStatus Status { get; set; }
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;

        public enum ResponseStatus
        {
            Success = 0, 
            NotFound = 1,
            BadQuery = 2,
            ValidationError = 3
        }
    }
}
