using CapaDeDominio.Commands;
using CapaDeDominio.DTOs;
using CapaDeDominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;



namespace CapaDeAplicacion.Services
{
    public interface IDestinoVentas
    {
        DestinoVenta CreateVenta(DestinoVentaDTOs destinoventa);
    }
    public class DestinoVentaService :IDestinoVentas 
    {
        private readonly IGenericRepository _repository;

        public DestinoVentaService(IGenericRepository repositorio)
        {
            _repository = repositorio;
        }
        public DestinoVenta CreateVenta(DestinoVentaDTOs destinoventa)
        {
            var entity = new DestinoVenta()
            {
                Destino = destinoventa.Destino,
                Nombre = destinoventa.Nombre,
                Descripcion = destinoventa.Descripcion
            };
            _repository.Add(entity);
            return entity;
        }
    }
}
