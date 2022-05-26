using Microsoft.AspNetCore.Builder;

namespace MiddlewaresHW
{
    public static class ExtensionMethods
    {
        public static IApplicationBuilder UseClassNoMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ClassNoMiddleware>();
        }

        public static IApplicationBuilder UseStudentNoMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<StudentNoMiddleware>();
        }
    }
}
