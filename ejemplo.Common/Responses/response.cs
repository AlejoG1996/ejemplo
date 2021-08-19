using System;
using System.Collections.Generic;
using System.Text;

namespace ejemplo.Common.Responses
{
    public class response
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public object  resultado  { get; set; }
    }
}
