using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiAutores.Filtros
{
    public class MiFiltroDeExcepcion : ExceptionFilterAttribute
    {
        private readonly ILogger<MiFiltroDeAccion> logger;

        public MiFiltroDeExcepcion(ILogger<MiFiltroDeAccion> logger)
        {
            this.logger = logger;
        }

        public override void OnException(ExceptionContext context)
        {
            logger.LogError(context.Exception, context.Exception.Message);

            base.OnException(context);
        }
    }
}
