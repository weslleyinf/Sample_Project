using Serilog;
using System;

namespace Logger.Service
{
    public class LoggerService
    {
        public static void Information(string text)
        {
            Log.Logger.Information(text);
        }

        public static void Alert(string text)
        {
            Log.Logger.Warning(text);
        }

        public static void Error(string text)
        {
            Log.Logger.Error(text);
        }

        public static void Exception(Exception exception)
        {
            Log.Logger.Error(exception.Message);
        }
    }
}
