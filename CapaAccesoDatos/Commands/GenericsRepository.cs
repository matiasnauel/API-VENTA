using System;
using System.Collections.Generic;
using System.Text;
using CapaDeDominio.Commands;
namespace CapaAccesoDatos.Commands
{
   public class GenericsRepository : IGenericsRepository
    {
        private readonly DatoDbContext _dbcontext;
        public GenericsRepository (DatoDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Add<T>(T entity) where T : class
        {
            _dbcontext.Add(entity);
            _dbcontext.SaveChanges();
        }
    }
}
