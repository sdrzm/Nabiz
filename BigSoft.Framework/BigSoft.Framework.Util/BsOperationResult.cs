using System;

namespace BigSoft.Framework.Util
{
    public class BsOperationResult
    {
        public string Message { get; set; }
        public BsResult BsResult { get; set; }
        public Exception Exception { get; set; }
        public object Value { get; set; }
    }

    public enum BsResult
    {
        Successful,
        UserError,
        SystemError
    }
}