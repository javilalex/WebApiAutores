using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiAutores.Filtros
{
    public class MiFiltroDeAccion : IActionFilter
    {
        public MiFiltroDeAccion(ILogger<MiFiltroDeAccion> logger)
        {
            Logger = logger;
        }

        private readonly ILogger<MiFiltroDeAccion> Logger;
            
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Logger.LogInformation("Antes de ejecutar la accion");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Logger.LogInformation("Despues de ejecutar la accion");
        }
    }
}
