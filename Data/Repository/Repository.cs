using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly DbSet<T> _entities;
        public Repository(DatabaseContext context)
        {
            _entities = context.Set<T>();
        }
        public virtual IQueryable<T> GetAll()
        {
            return _entities.AsQueryable();
        }

        public virtual T GetById(params object[] keys)
        {
            return _entities.Find(keys);
        }

        public virtual void Add(T entity)
        {
            _entities.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _entities.Update(entity);
        }

        public virtual void Remove(T entity)
        {
            _entities.Remove(entity);
        }
    }
}
