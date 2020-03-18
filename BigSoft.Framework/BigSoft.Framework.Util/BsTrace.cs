using NLog;
using System;

namespace BigSoft.Framework.Util
{
    public static class BsTrace
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public static void LogInfo(string message)
        {
            logger.Info(message);
        }

        public static void LogException(Exception ex, ResultType resultType)
        {
            string message = string.Format("{0} | {1}", resultType.ToString(), ex.ToString());
            logger.Error(ex, message);
        }
    }
}