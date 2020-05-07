using CapaDeDominio.Commands;
using CapaDeDominio.DTOs;
using CapaDeDominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeAplicacion.Services
{
    public interface IEstado
    {
        Estado CreateEstado(EstadoDTOs estado);
    }
    public class EstadoService : IEstado
    {
        private readonly IGenericRepository _repository;
        public EstadoService(IGenericRepository repositorio)
        {
            _repository = repositorio;
        }
        public Estado CreateEstado(EstadoDTOs estado)
        {
            var entity = new Estado()
            {
                Nombre = estado.Nombre,
                Id_ventaReclamo = estado.Id_ventaReclamo,
                Tipoestado= estado.Tipoestado
            };
            _repository.Add(entity);
            return entity;
        }
    }
}
