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
    public class CarritoController : ControllerBase
    {
        private readonly ICarritoService _service;
        public  CarritoController(ICarritoService service)
        {
            _service = service;
           
        }
        [HttpPost]
        public Carrito Post(CarritoDTOs carrito)
        {
            return _service.CrearCarrito(carrito);
        }
    }
}