using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio.Entity
{
    public class Carrito
    {
        private int id;
        private int id_producto;
        private int id_venta;
        private int valorcarrito;
        private int cantidadProducto;

        public int Id { get => id; set => id = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public int Id_venta { get => id_venta; set => id_venta = value; }
        public int Valorcarrito { get => valorcarrito; set => valorcarrito = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }

        public virtual ICollection<Venta> VentaNavigator { get; set; }
    }
}
