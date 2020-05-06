using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio.DTOs
{
  public  class EstadoDTOs
    {
        private string nombre;
        private int id_ventaReclamo;
        private int tipoestado;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_ventaReclamo { get => id_ventaReclamo; set => id_ventaReclamo = value; }
        public int Tipoestado { get => tipoestado; set => tipoestado = value; }
    }
}
