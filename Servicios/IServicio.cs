namespace WebApiAutores.Servicios
{
    public interface IServicio
    {
        public void RealizarTarea();
        public Guid ObtenerTransient();
        public Guid ObtenerScoped();
        public Guid ObtenerSingleton();
    }
    public class ServicioA : IServicio
    {
        private readonly ILogger<ServicioA> logger;
        private readonly ServicioTransient servicioTranscent;
        private readonly ServicioScoped servicioScoped;
        private readonly ServicioSingleton servicioSingleton;

        public ServicioA(ILogger<ServicioA> logger, ServicioTransient servicioTranscent, ServicioScoped servicioScoped, ServicioSingleton servicioSingleton)
        {
            this.logger = logger;
            this.servicioTranscent = servicioTranscent;
            this.servicioScoped = servicioScoped;
            this.servicioSingleton = servicioSingleton;
        }

        public Guid ObtenerScoped()
        {
            return servicioScoped.Guid;
        }

        public Guid ObtenerSingleton()
        {
            return servicioSingleton.Guid;
        }

        public Guid ObtenerTransient()
        {
            return servicioTranscent.Guid;
        }

        public void RealizarTarea()
        {
            throw new NotImplementedException();
        }
    }
    public class ServicioB : IServicio
    {
        public Guid ObtenerScoped()
        {
            throw new NotImplementedException();
        }

        public Guid ObtenerSingleton()
        {
            throw new NotImplementedException();
        }

        public Guid ObtenerTransient()
        {
            throw new NotImplementedException();
        }

        public void RealizarTarea()
        {

        }
    }

    public class ServicioTransient
    {
        public Guid Guid = Guid.NewGuid();
    }
    public class ServicioScoped
    {
        public Guid Guid = Guid.NewGuid();
    }
    public class ServicioSingleton
    {
        public Guid Guid = Guid.NewGuid();
    }
}
