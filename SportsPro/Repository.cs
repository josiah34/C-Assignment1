using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsPro.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected SportsPro context { get; set; }
        private DBSet<T> dbset { get; set; }
        public Repository(SportsPro ctx)
        {
            context = ctx;
            dbset = context.Set<T>();
        }

        public virtual IEnumberable<T> List(QueryOptions<T> options)
        {
            IQueryable<T> query = dbset; 
            foreach (string include in options.GetIncludes())
            {
                query = query.Include(include);
            }

            if (options.HasWhere)
                query = query.Where(options.where);
            if (options.HasOrderBy)
                query = query.OrderBy(options.OrderBy);
            if options.HasPaging)
                query = query.PageBy(options.PageNumber, options.PageSize);
            return query.ToList();
        }

        public virtual T Get(int id) => dbset.Add(entity);
        public virtual void Insert (T entity) = > dbset.Add(entity);
        public virtual void Update(T entity) = > dbset.Update(entity);
        public virtual void Delete(T entity) = > dbset.Remove(entity);
        public virtual void Save() => context.SaveChanges();
    }
    
 }
