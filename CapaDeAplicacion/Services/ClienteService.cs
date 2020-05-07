using CapaDeDominio.Commands;
using CapaDeDominio.DTOs;
using CapaDeDominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeAplicacion.Services
{
    public interface IClienteService
    {
        Cliente CreateCliente(ClienteDTOs cliente);
    }
    public class ClienteService : IClienteService

    {
        private readonly IGenericRepository _repository;
        public ClienteService (IGenericRepository repositorio)
        {
            _repository = repositorio;
        }
        public Cliente CreateCliente(ClienteDTOs cliente)
        {
            var entity = new Cliente()
            {
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Email= cliente.Email,
                Activo= cliente.Activo
            };
            _repository.Add(entity);
            return entity;
        }
    }
}
