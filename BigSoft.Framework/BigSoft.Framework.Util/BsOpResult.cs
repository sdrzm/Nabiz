namespace BigSoft.Framework.Util
{
    public enum ResultType
    {
        Successful,
        UserError,
        SystemError
    }

    public class BsOpResultBase
    {
        public string Message { get; set; }
        public ResultType ResultType { get; set; }
    }

    public class BsOpResult<T> : BsOpResultBase
    {
        public T Value { get; set; }
    }
}