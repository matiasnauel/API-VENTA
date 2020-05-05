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
        Carrito CrearCarrito(CarritoDTOs carrito);
    }
    public class CarritoService : ICarritoService
    {
        private readonly IGenericsRepository _repository;
        public CarritoService(IGenericsRepository repository)
        {
            _repository = repository;
        }

        public Carrito CrearCarrito(CarritoDTOs carrito)
        {
            var entity = new Carrito()
            {
                
                Id_producto = carrito.Id_producto,
                Id_venta = carrito.Id_venta,
                Valorcarrito = carrito.Valorcarrito,
                CantidadProducto =carrito.CantidadProducto


            
            };
            _repository.Add<Carrito>(entity);
            return entity;
        }
    }
}
