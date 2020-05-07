using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaAccesoDatos.Commands;
using CapaDeAplicacion.Services;
using CapaDeDominio.Commands;
using CapaDeDominio.DTOs;
using CapaDeDominio.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Venta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoEstadoController : ControllerBase
    {
        private readonly ITipoEstadoService _service;
        public TipoEstadoController(ITipoEstadoService servicio)
        {
            _service = servicio;
        }
        [HttpPost]
        public TipoEstado Post(TipoEstadoDTOs tipoestado)
        {
            return _service.CrearTipoEstado(tipoestado);
        }
    }
}