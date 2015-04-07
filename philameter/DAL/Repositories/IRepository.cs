using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace philameter.DAL.Repositories
{
    public interface IRepository<T> where T : class
    {
        List<T> Get();

        T Get(int id);

        T Update(T obj);

        T Insert(T obj);

        int Delete(T obj);
    }
}
