using System;
using System.Collections.Generic;
using System.Text;
using CapaDeDominio.Commands;
using CapaDeDominio.DTOs;
using CapaDeDominio.Entity;

namespace CapaDeAplicacion.Services
{
    public interface IDestinoVentas
    {
        DestinoVenta CrearDestino(DestinoVentasDTOs destino);
    }
    public class DestinoVentaService : IDestinoVentas
    {
        private readonly IGenericsRepository _repository;

        public DestinoVentaService(IGenericsRepository repositorio)
        {
            _repository = repositorio;
        }
        public DestinoVenta CrearDestino(DestinoVentasDTOs destino)
        {
            var entity = new DestinoVenta(){

                id = Guid.NewGuid(),

            };
        }

    }
}
