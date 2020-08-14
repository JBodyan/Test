using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Entities;

namespace Data.Repository
{
    public interface IRepository<T> where T : IEntity
    {
        IQueryable<T> GetAll();
        T GetById(params object[] keys);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);

    }
}
