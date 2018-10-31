using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Contracts;
namespace BLL.Realization
{
    public class CRUD<T> : ICRUD<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet _set;
        public CRUD(DbContext db)
        {
            _context = db;
            _set = db.Set<T>();
        }

        public void Create(T x)
        {
            _set.Add(x);
            _context.SaveChanges();
        }

        public void Delete(T x)
        {
            _set.Attach(x);
            _set.Remove(x);
            _context.SaveChanges();
        }

        public IEnumerable<T> Get()
        {
            return _set.AsNoTracking<T>().AsEnumerable();
        }

        public void Update(T x)
        {
            _context.Entry<T>(x).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
