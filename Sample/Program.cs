using Logger.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Sample.Kernel.Builder;
using Serilog;

namespace Sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().UseConfiguration();

            LoggerService.Information("Starting up");

            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
                .InitializeHost();
        }
    }

}
