using CapaDeDominio.Commands;
using CapaDeDominio.DTOs;
using CapaDeDominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeAplicacion.Services
{

    public interface IVentaService
    {
        Venta CrearVenta(VentaDTOs venta);
    }
    public class VentaService /*: IVentaService*/
    {
        //private readonly IGenericRepository _repository;
        //public VentaService(IGenericRepository repositorio)
        //{
        //    _repository = repositorio;
        //}
        //public Venta CrearVenta(VentaDTOs venta)
        //{
        //    var entity = new Venta()
        //    {
        //        Id_cliente = venta.Id_cliente,
        //        Id_carrito = venta.Id_carrito,
        //        FechaVenta = venta.FechaVenta,
        //        Id_destinoventa = venta.Id_destinoventa,
        //        Id_tomapago = venta.Id_tomapago,
        //        Id_estadoventa = venta.Id_estadoventa
        //    };
        //    _repository.Add(entity);
        //    return entity;
        //}
    }
}
