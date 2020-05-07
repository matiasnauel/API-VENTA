using CapaDeDominio.Commands;
using CapaDeDominio.DTOs;
using CapaDeDominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeAplicacion.Services
{
    public interface ITipoEstadoService
    {
        TipoEstado CrearTipoEstado(TipoEstadoDTOs tipo);
    }
   public class TipoEstadoService : ITipoEstadoService
    {
        private IGenericRepository _repository;
        public TipoEstadoService(IGenericRepository repositorio)
        {
            _repository = repositorio;
        }

        public TipoEstado CrearTipoEstado(TipoEstadoDTOs tipo)
        {
            var entity = new TipoEstado()
            {
                Tipo = tipo.Tipo
            };
            _repository.Add(entity);
            return entity;
        }
    }
}
