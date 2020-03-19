using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace Sample.Kernel.Builder
{
    public static class ApplicationHostBuilderExtensions
    {
        public static void InitializeHost(this IHostBuilder hostBuilder)
        { 
            hostBuilder.UseSerilog().Build().Run();
        }
    }
}
