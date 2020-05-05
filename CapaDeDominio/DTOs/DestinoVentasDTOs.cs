using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio.DTOs
{
    class DestinoVentasDTOs
    {
        private string destino;
        private string nombre;
        private string descripcion;

        public string Destino { get => destino; set => destino = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
