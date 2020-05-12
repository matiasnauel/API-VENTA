using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaDeAplicacion.Services;
using CapaDeDominio.DTOs;
using CapaDeDominio.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace API_Venta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarritoController : ControllerBase
    {
        private readonly ICarritoService _service;
        public CarritoController(ICarritoService service)
        {
            _service = service;
            
        }
        [HttpPost]
        public Carrito Post(CarritoDTOs carrito)
        {
            return _service.CreateCarrito(carrito);
        }
        [HttpDelete]
        public Carrito Delete(CarritoDTOs carrito)
        {
            return _service.DeleteCarrito(carrito);
        }
        [HttpPut]
        public Carrito Update(CarritoDTOs carrito)
        {
            return _service.UpdateCarrito(carrito);
        }
        [HttpGet]

        public IEnumerable<Carrito> Get()
        {
            return _service.GetALL();

        }
        [HttpGet("{id}")] 
        public Carrito GetiD(int id)
        {
            return _service.GetByID(id);
        }



    }
}