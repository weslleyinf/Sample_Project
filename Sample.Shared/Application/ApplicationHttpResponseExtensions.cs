using Microsoft.AspNetCore.Http;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Sample.Kernel.Response
{
    public static class ApplicationHttpResponseExtensions
    {
        public static Task WriteInternalError(this HttpResponse response, string message)
        {
            response.StatusCode = (int)HttpStatusCode.InternalServerError;

            response.ContentType = MediaTypeNames.Application.Json;

            return response.WriteAsync(message);
        }
    }
}
