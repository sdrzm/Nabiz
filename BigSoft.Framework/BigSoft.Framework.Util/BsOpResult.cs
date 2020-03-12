using System;

namespace BigSoft.Framework.Util
{
    public enum Success
    {
        Successful,
        UserError,
        SystemError
    }

    public class BsOpResultBase
    {
        public string Message { get; set; }
        public Success IsSuccessful { get; set; }
        public Exception Exception { get; set; }
    }

    public class BsOpResult<T> : BsOpResultBase
    {
        public T Value { get; set; }
    }
}