using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsPro.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> List(QueryOptions<T> options);
        T Get(int id);
        void insert(T entity);
        void update(T entity);
        void delete(T entity);
        void save();

    }
}
