using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio.DTOs
{
   public class ClienteDTOs
    {
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public byte Activo { get; set; }
        public string Contraseña { get; set; }
    }
}
