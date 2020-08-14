using System;
using System.Collections.Generic;
using System.Text;
using Data.Entities;

namespace Data.Repository
{
    public interface IUnitOfWork
    {
        IRepository<SomeData> SomeDataRepository { get; }
        void Commit();
        void Rollback();
    }
}
