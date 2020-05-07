﻿using System;
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
    public class DestinoVentaController : ControllerBase
    {
        private readonly IDestinoVentas _service;
        public DestinoVentaController(IDestinoVentas servicio)
        {
            _service = servicio;
        }
        [HttpPost]
        public DestinoVenta Post(DestinoVentaDTOs destinoventa)
        {
            return _service.CreateVenta(destinoventa);
        }
    }
}