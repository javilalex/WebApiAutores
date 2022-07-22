﻿namespace WebApiAutores.Servicios
{
    public class EscribirEnArchivo : IHostedService
    {
        private readonly IWebHostEnvironment env;
        private readonly string nombreArchivo = "archivo.txt";
        private Timer timer;

        public EscribirEnArchivo(IWebHostEnvironment env)
        {
            this.env = env;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
            Escribir("Proceso iniciado");
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            timer.Dispose();
            Escribir("Proceso terminado");
            return Task.CompletedTask;
        }
        private void DoWork(object state)
        {
            Escribir($"Proceso en ejecucion: {DateTime.Now:dd/MM/yyyy hh:mm:ss}");
        }
        private void Escribir(string message)
        {
            var ruta = $@"{env.ContentRootPath}\wwwroot\{nombreArchivo}";

            using(StreamWriter writer = new StreamWriter(ruta, append: true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
