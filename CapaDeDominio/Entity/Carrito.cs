using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio.Entity
{
    public class Carrito
    {
        public Guid id {get;set;}

        public Guid id_producto {get;set;}

        public Guid id_venta {get;set;}

        public int valorcarrito {get;set;}

        public int cantidadProducto {get;set;}

        public virtual Venta VentaNavigator { get; set; }

        public virtual Producto ProductoNavigator { get; set; }

        public virtual Cliente ClienteNavigator { get; set; }
    }
}
