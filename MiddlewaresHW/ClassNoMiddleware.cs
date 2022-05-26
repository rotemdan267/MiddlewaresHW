using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MiddlewaresHW
{
    public class ClassNoMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var path = context.Request.Path.Value;

            if (path.StartsWith("/students/"))
            {
                path = path.Substring(10);
                int i = path.IndexOf('/');
                if (i > 0)
                {
                    path = path.Remove(i);
                }
            }

            await context.Response.WriteAsync("Class no. " + path + "\n");
            await next(context);

        }
    }
}
