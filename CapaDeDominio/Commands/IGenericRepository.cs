using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace CapaDeDominio.Commands
{
   public interface IGenericRepository
    {
        public void Add<T>(T entity) where T : class;
      
    }
}
