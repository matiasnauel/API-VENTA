using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio.DTOs
{
   public class FormaPagoDTOs
    {
        private string forma;
        private string descripcion;

        public string Forma { get => forma; set => forma = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
