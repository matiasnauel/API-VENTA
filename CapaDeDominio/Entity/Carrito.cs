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

        public virtual ICollection<Venta> VentaNavigator { get; set; }

        public virtual ICollection<Producto> ProductoNavigator { get; set; }
    }
}
