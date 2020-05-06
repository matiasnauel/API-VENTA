using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio.Entity
{
    public class Venta
    {
        public Guid VentaId {get;set;}
        public Guid id_cliente{get;set;}
        public Guid id_carrito{get;set;}
        public Guid fechaVenta{get;set;}
        public Guid id_destinoventa{get;set;}
        public Guid id_tomapago{get;set;}
        public Guid id_estadoventa{get;set;}

          
        public virtual Carrito CarritoNavigator { get; set; }
        public virtual Estado EstadoVentaNavigator { get; set; }
        public virtual FormaPago FormaPagoNavigator { get; set; }
        public virtual DestinoVenta DestinoVentaNavigator { get; set; }
        public virtual Cliente ClienteNavigator {get;set;}



       
    }
}
