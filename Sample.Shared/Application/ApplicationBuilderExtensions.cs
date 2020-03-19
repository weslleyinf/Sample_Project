using Logger.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Sample.Kernel.Response;

namespace Sample.Kernel.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static void UseException(this IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Run(async context =>
            {
                var exceptionHandler = context.Features.Get<IExceptionHandlerPathFeature>();

                if (exceptionHandler != null)
                {
                    LoggerService.Exception(exceptionHandler.Error);
                }

                await context.Response.WriteInternalError("Erro Interno, tente mais uma vez :(");
            });
        }
    }
}
