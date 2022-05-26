using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MiddlewaresHW
{
    public class StudentNoMiddleware : IMiddleware
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
                    path = path.Substring(i + 1);
                }
            }

            await context.Response.WriteAsync("Student no. " + path + "\n");
            await next(context);

        }
    }
}
