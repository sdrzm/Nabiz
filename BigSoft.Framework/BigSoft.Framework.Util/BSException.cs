using System;

namespace BigSoft.Framework.Util
{
    [Serializable]
    public class BsException : Exception
    {
        public BsException(string message) : base(message)
        {
        }
    }
}