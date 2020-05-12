using CapaDeDominio.Commands;
using CapaDeDominio.DTOs;
using CapaDeDominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeAplicacion.Services
{
    public interface IVentaReclamoService
    {
        VentaReclamo CrearVentaReclamo(VentaReclamoDTOs venta);
    }
    public class VentaReclamoService/* : IVentaReclamoService*/
    {
        //private readonly IGenericRepository _repository;
        //public VentaReclamoService (IGenericRepository repositorio)
        //{
        //    _repository = repositorio;
        //}
        //public VentaReclamo CrearVentaReclamo(VentaReclamoDTOs venta)
        //{
        //    var entity = new VentaReclamo()
        //    {
        //        Reclamo = venta.Reclamo
        //    };
        //    _repository.Add(entity);
        //    return entity;
        //}
    }
}
