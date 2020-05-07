using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDominio.Commands;
using Microsoft.EntityFrameworkCore;

namespace CapaAccesoDatos.Commands
{
   public class GenericsRepository : IGenericRepository
    {
        private readonly DatoDbContext _context;
        public GenericsRepository(DatoDbContext dbcontex)
        {
            _context = dbcontex;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete<T>(T entity) where T : class
        {
            if(entity == null)
            {
                throw new ArgumentNullException("no funciona esta vacio D:");
            }
            _context.Remove<T>(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll<T>() where T : class;
        {
            throw new NotImplementedException();
        }

        public List<T> GetbyID<T>(int iD) where T : class;
        {
          
        }

        public void Update<T>(T entity) where T : class
        {
            if(entity == null)
            {
                throw new ArgumentNullException("No funciona esta vacio D:");
            }
            _context.Remove<T>(entity);
            _context.SaveChanges();
        }
    }
}
