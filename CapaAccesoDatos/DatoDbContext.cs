using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CapaDeDominio.Entity;
namespace CapaAccesoDatos
{
    public class DatoDbContext : DbContext
    {
        public DatoDbContext(DbContextOptions<DatoDbContext> options):base(options)
        {

        }
        public DbSet<Carrito> Carritos { get; set; }
        public DbSet<DestinoVentaService> DestinoVentas { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<FormaPago> FormaPagos { get; set; }
        public DbSet<TipoEstado> TipoEstados { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<VentaReclamo> VentasReclamos { get; set; }
        public DbSet<Producto> Productos { get; set; }

    }
}
