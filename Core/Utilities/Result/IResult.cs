using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public interface IResult
    {
        public bool Succes { get; }
        public string Message { get; }
    }
}
