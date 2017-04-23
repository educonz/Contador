using System;
using System.Reflection;
using Base.Core.Logger;

namespace Base.Core.Log4Net
{
    public class LogProvider : ILog
    {
        private log4net.ILog _logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public void SetMethodLog(Type type)
        {
            _logger = log4net.LogManager.GetLogger(type);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void DebugFormat(string message, params object[] args)
        {
            _logger.DebugFormat(message, args);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Error(string message, Exception exception)
        {
            _logger.Error(message, exception);
        }

        public void ErrorFormat(string format, params object[] args)
        {
            _logger.ErrorFormat(format, args);
        }

        public void Fatal(string message)
        {
            _logger.Fatal(message);
        }

        public void Fatal(string message, Exception exception)
        {
            _logger.Fatal(message, exception);
        }

        public void FatalFormat(string format, params object[] args)
        {
            _logger.FatalFormat(format, args);
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void InfoFormat(string message, params object[] args)
        {
            _logger.InfoFormat(message, args);
        }

        public void Warn(string message)
        {
            _logger.Warn(message);
        }

        public void WarnFormat(string message, params object[] args)
        {
            _logger.WarnFormat(message, args);
        }
    }
}
