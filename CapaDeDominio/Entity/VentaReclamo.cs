using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio.Entity
{
   public  class VentaReclamo
    {
        private int id;
        private string reclamo;

        public int Id { get => id; set => id = value; }
        public string Reclamo { get => reclamo; set => reclamo = value; }
    }
}
