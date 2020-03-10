using System;
using System.Runtime.Serialization;

namespace BigSoft.Framework.Util
{
    [Serializable]
    public class BsException : Exception
    {
        public BsResult BsResult { get; }

        public BsException() : base()
        { }

        public BsException(string msg, BsResult result)
            : base(msg)
        {
            BsResult = result;
        }

        public BsException(string message) : base(message)
        {
        }

        public BsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}