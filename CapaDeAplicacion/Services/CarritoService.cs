using CapaDeDominio.Commands;
using CapaDeDominio.DTOs;
using CapaDeDominio.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeAplicacion.Services
{

    public interface ICarritoService
    {
        Carrito CreateCarrito(CarritoDTOs carrito);
        Carrito DeleteCarrito(CarritoDTOs carrito);
        Carrito UpdateCarrito(CarritoDTOs carrito);
        IEnumerable<Carrito> GetALL();

        Carrito GetByID(int id);
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
            _repository.Add<Carrito>(entity);
            return entity;
        }

        public Carrito DeleteCarrito(CarritoDTOs carrito)
        {
            var entity = new Carrito()
            {
                Id = carrito.Id,
                Valorcarrito = carrito.Valorcarrito,
                CantidadProducto = carrito.CantidadProducto
            };
            _repository.Delete<Carrito>(entity);
            return entity;
        }

        public IEnumerable<Carrito> GetALL()
        {
             var entity = _repository.GetALL<Carrito>();
            return entity;
        }

        public Carrito GetByID(int id)
        {
            return _repository.GetBy<Carrito>(id);
        }

        

        public Carrito UpdateCarrito(CarritoDTOs carrito)
        {
            var entity = new Carrito()
            {
                Id = carrito.Id,
                Valorcarrito = carrito.Valorcarrito,
                CantidadProducto = carrito.CantidadProducto
            };
            _repository.Update<Carrito>(entity);
            return entity;
        }
    }
}
