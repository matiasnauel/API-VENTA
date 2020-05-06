using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio.DTOs
{
   public  class CarritoDTOs
    {

        public Guid id_producto {get;set;}

        public Guid id_venta {get;set;}

        public int valorcarrito {get;set;}

        public int cantidadProducto {get;set;}
    }
}
