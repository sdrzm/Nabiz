using System;
using System.Runtime.Serialization;

namespace BigSoft.Framework.Util
{
    [Serializable]
    public class BsException : Exception
    {
        #region Public Properties

        public Success BsResult { get; }

        #endregion Public Properties

        #region Protected Constructors

        protected BsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        #endregion Protected Constructors

        #region Public Constructors

        public BsException() : base()
        { }

        public BsException(string msg, Success result) : base(msg) => BsResult = result;

        public BsException(string message) : base(message)
        {
        }

        public BsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        #endregion Public Constructors
    }
}