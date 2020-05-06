using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio.DTOs
{
    class EstadoDTOs
    {

        public string nombre{get;set;}

        public int id_ventaReclamo{get;set;}

        public int tipoestado{get;set;}

        public virtual ICollection<TipoEstado> TipoEstadoNavigator { get; set; }

        public virtual ICollection<VentaReclamo> VentaReclamoNavigator { get; set; }
    }
}
