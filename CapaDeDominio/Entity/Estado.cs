using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio.Entity
{
    public class Estado
    {
        public Guid id {get;set;}

        public string nombre{get;set;}

        public Guid id_ventaReclamo{get;set;}

        public Guid tipoestado{get;set;}

        public virtual TipoEstado TipoEstadoNavigator { get; set; }

        public virtual VentaReclamo VentaReclamoNavigator { get; set; }
    }
}
