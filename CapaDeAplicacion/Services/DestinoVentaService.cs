using CapaDeDominio.Commands;
using CapaDeDominio.DTOs;
using CapaDeDominio.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CapaDeAplicacion.Services
{
    public interface IDestinoVentaService
    {
        CapaDeDominio.Entity.DestinoVentaService CrearDestinoDatos(DestinoVentasDTOs Destinodat);
    }
    class DestinoVentaService : IDestinoVentaService
    {
        private readonly IGenericsRepository _Repository;

        public DestinoVentaService(IGenericsRepository repositorio)
        {
            _Repository = repositorio;
        }
        public CapaDeDominio.Entity.DestinoVentaService CrearDestinoDatos(DestinoVentasDTOs Destinodat)
        {
            var entity = new CapaDeDominio.Entity.DestinoVentaService()
            {
                Destino = Destinodat.Destino,
                Nombre = Destinodat.Nombre,
                Descripcion = Destinodat.Descripcion
            };
            _Repository.Add<CapaDeDominio.Entity.DestinoVentaService>(entity);
            return entity;
        }
    }
}
