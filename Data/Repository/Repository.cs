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
        public IQueryable<T> GetAll()
        {
            return _entities.AsQueryable();
        }

        public T GetById(params object[] keys)
        {
            return _entities.Find(keys);
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
        }

        public void Remove(T entity)
        {
            _entities.Remove(entity);
        }
    }
}
