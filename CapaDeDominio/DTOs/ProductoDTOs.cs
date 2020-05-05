using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio.DTOs
{
    class ProductoDTOs
    {
        private string nombre;
        private int precio;
        private string descripcion;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
