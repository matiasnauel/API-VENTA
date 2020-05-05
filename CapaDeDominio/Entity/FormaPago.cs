using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio.Entity
{
   public  class FormaPago
    {
        private int id;
        private string forma;
        private string descripcion;

        public int Id { get => id; set => id = value; }
        public string Forma { get => forma; set => forma = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
