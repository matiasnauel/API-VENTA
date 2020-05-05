using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio.Entity
{
    public class Estado
    {
        private int id;
        private string nombre;
        private int id_ventaReclamo;
        private int tipoestado;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_ventaReclamo { get => id_ventaReclamo; set => id_ventaReclamo = value; }
        public int Tipoestado { get => tipoestado; set => tipoestado = value; }

        public virtual ICollection<TipoEstado> TipoEstadoNavigator { get; set; }
        public virtual ICollection<VentaReclamo> VentaReclamoNavigator { get; set; }
    }
}
