using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio.Entity
{
   public class Producto
    {
        private int id;
        private string nombre;
        private int precio;
        private string descripcion;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
