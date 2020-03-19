
using Microsoft.Extensions.Configuration;
using Serilog;

namespace Logger.Service
{
    public static class LoggerConfigurationExtensions
    {
        public static ILogger UseConfiguration(this LoggerConfiguration logger)
        {
            var configuration = new ConfigurationBuilder().UseSettings();

            return logger.ReadFrom.Configuration(configuration).CreateLogger();
        }
    }
}
