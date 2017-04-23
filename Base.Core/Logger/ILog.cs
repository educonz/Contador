using System;

namespace Base.Core.Logger
{
    public interface ILog
    {
        void SetMethodLog(Type type);

        void Debug(string message);

        void DebugFormat(string message, params object[] args);

        void Info(string message);

        void InfoFormat(string message, params object[] args);

        void Warn(string message);

        void WarnFormat(string message, params object[] args);

        void Error(string message);

        void Error(string message, Exception exception);

        void ErrorFormat(string format, params object[] args);

        void Fatal(string message);

        void Fatal(string message, Exception exception);

        void FatalFormat(string format, params object[] args);
    }
}
