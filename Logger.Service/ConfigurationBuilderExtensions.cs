using Microsoft.Extensions.Configuration;

namespace Logger.Service
{
    public static class ConfigurationBuilderExtensions
    {
        public static IConfigurationRoot UseSettings(this IConfigurationBuilder configurationBuilder)
        {
            return configurationBuilder.AddJsonFile("appsettings.json").Build();
        }
    }
}
