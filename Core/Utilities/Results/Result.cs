using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool succes, string message) :this(succes)
        {
            Message = message;
            Success = succes;
        }

        public Result(bool succes)
        {
            Success = succes;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
