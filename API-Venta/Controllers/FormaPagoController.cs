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
    public class FormaPagoController : ControllerBase
    {
        private readonly IFormaPagoService _service;
        public FormaPagoController(IFormaPagoService servicio)
        {
            _service = servicio;
        }
        [HttpPost]
        public FormaPago Post(FormaPagoDTOs formapago)
        {
            return _service.CreatePagos(formapago);
        }
    }
}