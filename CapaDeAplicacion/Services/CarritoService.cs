using CapaDeDominio.Commands;
using CapaDeDominio.DTOs;
using CapaDeDominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeAplicacion.Services
{
   
    public interface ICarritoService
    {


        Carrito CreateCarrito(CarritoDTOs carrito);
    }
    public class CarritoService : ICarritoService
    {
        private readonly IGenericRepository _repository;
        public CarritoService(IGenericRepository repositorio)
        {
            _repository = repositorio;
        }

        public Carrito CreateCarrito(CarritoDTOs carrito)
        {
            var entity = new Carrito()
            {
               
                Valorcarrito = carrito.Valorcarrito,
                CantidadProducto = carrito.CantidadProducto
            };
            _repository.Add(entity);
            return entity;
        }
    }
}
