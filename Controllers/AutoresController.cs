using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiAutores.Contextos;
using WebApiAutores.Entidades;
using WebApiAutores.Filtros;
using WebApiAutores.Servicios;

namespace WebApiAutores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class AutoresController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        //private readonly IServicio servicio;
        //public ServicioTransient servicioTranscent;
        //public ServicioScoped servicioScoped;
        //public ServicioSingleton servicioSingleton;
        //private readonly ILogger<AutoresController> logger;

        //public AutoresController(ApplicationDbContext context, IServicio servicio, ServicioTransient servicioTranscent, ServicioScoped servicioScoped, ServicioSingleton servicioSingleton, ILogger<AutoresController> logger)
        //{
        //    this.context = context;
        //    this.servicio = servicio;
        //    this.servicioTranscent = servicioTranscent;
        //    this.servicioScoped = servicioScoped;
        //    this.servicioSingleton = servicioSingleton;
        //    this.logger = logger;
        //}

        //[HttpGet("Guid")]
        ////[ResponseCache(Duration =10)]
        //[ServiceFilter(typeof(MiFiltroDeAccion))]
        //public ActionResult ObtenerGuids()
        //{
        //    return Ok(new
        //    {
        //        AutoresController_Transcent = servicioTranscent.Guid,
        //        ServicioA_Transcient = servicio.ObtenerTransient(),
        //        AutoresController_Scoped = servicioScoped.Guid,
        //        ServicioA_Scoped = servicio.ObtenerScoped(),
        //        AutoresController_Singleton = servicioSingleton.Guid,
        //        ServicioA_Singleton = servicio.ObtenerSingleton(),
        //    });
        //}

        ///// <summary>
        ///// Obtener listado de autores
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet]
        //[HttpGet("Listado")]
        //[HttpGet("/Listado")]
        //[ResponseCache(Duration = 10)]
        //public async Task<ActionResult<List<Autor>>> Get()
        //{
        //    throw new Exception("Hola que hace");
        //    logger.LogInformation("Estamos obteniendo los autores");
        //    logger.LogWarning("Estamos obteniendo los autores");
        //    return await context.Autores.Include(x => x.Libros).ToListAsync();
        //}

        //[HttpGet("Primer")]
        //public async Task<ActionResult<Autor>> PrimerAutor([FromHeader] int miValor)
        //{
        //    return await context.Autores.FirstOrDefaultAsync();
        //}

        ////[HttpGet("{id:int}/{param2?")]
        //[HttpGet("{id:int}/{param2=persona}")]
        //public async Task<ActionResult<Autor>> Get(int id, string param2)
        //{
        //    var autor = await context.Autores.FirstOrDefaultAsync(x => x.Id == id);

        //    if (autor == null) return NotFound();

        //    return autor;
        //}
        //[HttpGet("{nombre}")]
        //public async Task<ActionResult<Autor>> Get(string nombre)
        //{
        //    var autor = await context.Autores.FirstOrDefaultAsync(x => x.Nombre.Contains(nombre));

        //    if (autor == null) return NotFound();

        //    return autor;
        //}
        ///// <summary>
        ///// Ingreso de nuevos autores
        ///// </summary>
        ///// <param name="autor"></param>
        ///// <returns></returns>
        //[HttpPost]
        //public async Task<ActionResult<Autor>> Post(Autor autor)
        //{
        //    if (await context.Autores.AnyAsync(x => x.Nombre == autor.Nombre))
        //    {
        //        return BadRequest($"Ya existe un autor con el nombre: {autor.Nombre}");
        //    }

        //    context.Add(autor);
        //    await context.SaveChangesAsync();
        //    return autor;
        //}
        ///// <summary>
        ///// Actualizacion de la informacion del autor
        ///// </summary>
        ///// <param name="autor"></param>
        ///// <returns></returns>
        //[HttpPut("{id:int}")]
        //public async Task<ActionResult> Put(Autor autor, int id)
        //{
        //    if (autor.Id != id) return BadRequest("El id del autor no coincide con el id de la URL");

        //    var existe = await context.Autores.AnyAsync(x => x.Id == id);

        //    if (!existe) return NotFound();

        //    context.Update(autor);
        //    await context.SaveChangesAsync();
        //    return Ok();
        //}
        ///// <summary>
        ///// Borrado del autor
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //[HttpDelete("{id:int}")]
        //public async Task<ActionResult> Delete(int id)
        //{
        //    var existe = await context.Autores.AnyAsync(x => x.Id == id);

        //    if (!existe) return NotFound();

        //    context.Remove(new Autor { Id = id });
        //    await context.SaveChangesAsync();

        //    return Ok();
        //}
    }
}
