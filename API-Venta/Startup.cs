using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using CapaAccesoDatos;
using CapaDeDominio.Commands;
using CapaDeAplicacion.Services;
using CapaAccesoDatos.Commands;
using CapaDeDominio.Entity;

namespace API_Venta
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            var conecctionString = Configuration.GetSection("ConnectionString").Value;
            services.AddDbContext<DatoDbContext>(option => option.UseSqlServer(conecctionString));
            services.AddTransient<IGenericRepository, GenericsRepository>();
            services.AddTransient<ICarritoService, CarritoService>();
            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<IDestinoVentas,DestinoVentaService>();
            services.AddTransient<IFormaPagoService,FormaPagoService>();
            services.AddTransient<ITipoEstadoService, TipoEstadoService>();
            services.AddTransient<IVentaService, VentaService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
