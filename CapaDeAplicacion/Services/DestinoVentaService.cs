using System;
using System.Collections.Generic;
using System.Text;
using CapaDeDominio.Commands;
using CapaDeDominio.DTOs;


namespace CapaDeAplicacion.Services
{
    public interface IDestinoVentas
    {
       
    }
    public class DestinoVentaService : IDestinoVentas
    {
        private readonly IGenericsRepository _repository;

        public DestinoVentaService(IGenericsRepository repositorio)
        {
            _repository = repositorio;
        }
       

    }
}
