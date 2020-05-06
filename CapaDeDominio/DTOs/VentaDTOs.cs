using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio.DTOs
{
  public  class VentaDTOs
    {
        private int id_cliente;
        private int id_carrito;
        private int fechaVenta;
        private int id_destinoventa;
        private int id_tomapago;
        private int id_estadoventa;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_carrito { get => id_carrito; set => id_carrito = value; }
        public int FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public int Id_destinoventa { get => id_destinoventa; set => id_destinoventa = value; }
        public int Id_tomapago { get => id_tomapago; set => id_tomapago = value; }
        public int Id_estadoventa { get => id_estadoventa; set => id_estadoventa = value; }
    }
}
