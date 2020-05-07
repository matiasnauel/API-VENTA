using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaDeAplicacion.Services;
using CapaDeDominio.DTOs;
using CapaDeDominio.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Venta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaReclamoController : ControllerBase
    {
        private IVentaReclamoService _service;
        public VentaReclamoController(IVentaReclamoService servicio)
        {
            _service = servicio;
        }
        [HttpPost]
        public VentaReclamo Post(VentaReclamoDTOs ventareclamo)
        {
            return _service.CrearVentaReclamo(ventareclamo);
        }
    }
}