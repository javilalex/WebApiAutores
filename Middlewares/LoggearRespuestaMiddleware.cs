namespace WebApiAutores.Middlewares
{
    public static class LoggearRespuestaMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoggearRespuestaHttp(this IApplicationBuilder app)
        {
            return app.UseMiddleware<LoggearRespuestaMiddleware>();
        }
    }

    public class LoggearRespuestaMiddleware
    {
        public LoggearRespuestaMiddleware(RequestDelegate next)
        {
            Next = next;
        }

        public RequestDelegate Next { get; }

        //invoke o Invoke Async

        public async Task InvokeAsync(HttpContext context, ILogger<LoggearRespuestaMiddleware> logger)
        {
            using (var memoryString = new MemoryStream())
            {
                var rawResponse = context.Response.Body;
                context.Response.Body = memoryString;

                await Next.Invoke(context);

                memoryString.Seek(0, SeekOrigin.Begin);
                string response = new StreamReader(memoryString).ReadToEnd();
                memoryString.Seek(0, SeekOrigin.Begin);

                await memoryString.CopyToAsync(rawResponse);
                context.Response.Body = rawResponse;
                logger.LogInformation(response);
            }
        }
    }
}
