using CapaDeDominio.Commands;
using CapaDeDominio.DTOs;
using CapaDeDominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeAplicacion.Services
{
    public interface IFormaPagoService
    {
        FormaPago CreatePagos(FormaPagoDTOs formapago);
    }
    public class FormaPagoService : IFormaPagoService
    {
        private readonly IGenericRepository _repository;
        public FormaPagoService(IGenericRepository repositorio)
        {
            _repository = repositorio;
        }
        public FormaPago CreateFormaPago(FormaPago formapago)
        {
            var entity = new FormaPago()
            {
                Forma = formapago.Forma,
                Descripcion = formapago.Descripcion
            };
            _repository.Add(entity);
            return entity;
        }
    }
}
