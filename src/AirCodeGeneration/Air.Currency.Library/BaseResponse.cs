using System;
using System.Collections.Generic;
using System.Text;

namespace Air.Currency.Library
{
    public class BaseResponse<T>
    {
        public string Value { get; set; }

        public T Data { get; set; }
    }
}
