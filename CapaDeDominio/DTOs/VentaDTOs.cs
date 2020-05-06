using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio.DTOs
{
    class VentaDTOs
    {
       
        public Guid id_cliente{get;set;}
        public Guid id_carrito{get;set;}
        public Guid fechaVenta{get;set;}
        public Guid id_destinoventa{get;set;}
        public Guid id_tomapago{get;set;}
        public Guid id_estadoventa{get;set;}
    }
}
