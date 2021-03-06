﻿using CapaDeDominio.Commands;
using CapaDeDominio.DTOs;
using CapaDeDominio.Entity;
using CapaDeDominio.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeAplicacion.Services
{

    public interface IVentaService
    {
        Venta CrearVenta(VentaDTOs venta);
     
        ICollection<Venta> GetVenta();
        bool DeleteVenta(VentaDTOs venta);
        bool UpdateVenta(VentaDTOs venta);
        Task<List<ClienteDTOs>> GetCliente();

        Venta GetId(int id);
    }
    public class VentaService : IVentaService
    {
        private readonly IGenericRepository _repository;
        private readonly IQueryVenta query;

        public VentaService(IGenericRepository repository)
        {
            _repository = repository;
        }

        public VentaService(IGenericRepository repository, IQueryVenta query)
        {
            _repository = repository;
            this.query = query;
        }

        public Venta CrearVenta(VentaDTOs venta)
        {
            var EstadoNavigator = _repository.GetBy<Estado>(venta.Id_estadoventa);
            var FormaPagoNavigator = _repository.GetBy<FormaPago>(venta.Id_tomapago);
            var DestinoVentaNavigator = _repository.GetBy<DestinoVenta>(venta.Id_destinoventa);
            var entity = new Venta()
            {
                Id_cliente = venta.Id_cliente,
                Id_carrito = venta.Id_carrito,
                FechaVenta = DateTime.Now,
                Id_destinoventa = venta.Id_destinoventa,
                Id_tomapago = venta.Id_tomapago,
                Id_estadoventa = venta.Id_estadoventa,
                EstadoVentaNavigator =EstadoNavigator,
                FormaPagoNavigator = FormaPagoNavigator,
                DestinoVentaNavigator = DestinoVentaNavigator
            };
            _repository.Add(entity);
            return entity;
        }

        public ICollection<Venta> GetVenta()
        {
            return _repository.GetALL<Venta>().ToList();
        }

        public bool DeleteVenta(VentaDTOs venta)
        {
            var entity = new Venta()
            {
                VentaId = venta.Id,
                Id_cliente = venta.Id_cliente,
                Id_carrito = venta.Id_carrito,
                FechaVenta = venta.FechaVenta,
                Id_destinoventa = venta.Id_destinoventa,
                Id_tomapago = venta.Id_tomapago,
            };
            return _repository.Delete<Venta>(entity);
        }

        public bool UpdateVenta(VentaDTOs venta)
        {
            var entity = new Venta()
            {
                VentaId = venta.Id,
                Id_cliente = venta.Id_cliente,
                Id_carrito = venta.Id_carrito,
                FechaVenta = venta.FechaVenta,
                Id_destinoventa = venta.Id_destinoventa,
                Id_tomapago = venta.Id_tomapago,
            };
            return _repository.Update<Venta>(entity);
        }

        public Venta GetId(int id)
        {
            return _repository.GetBy<Venta>(id);
        }

        public Task<List<ClienteDTOs>> GetCliente()
        {
           return  query.GetCliente();
        }
    }
}
