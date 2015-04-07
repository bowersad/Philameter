using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using philameter.DAL.Entities;

namespace philameter.DAL.Repositories
{
    public class BaseRepository<T> :  IRepository<T> where T : class 
    {
        private PhilaModel _context;

        public BaseRepository(PhilaModel context)
        {
            _context = context;
        }

        public List<T> Get()
        {

            return _context.Set<T>().ToList();
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public T Update(T obj)
        {
            _context.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            //_context.Set<T>().Attach(obj);

            return obj;
        }

        public T Insert(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public int Delete(T obj)
        {
            _context.Set<T>().Remove(obj);
            _context.SaveChanges();

            return _context.SaveChanges();
        }
    }
}