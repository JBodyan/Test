using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;

        private IRepository<SomeData> _someDataRepository;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public IRepository<SomeData> SomeDataRepository
        {
            get { return _someDataRepository ??= new Repository<SomeData>(_context); }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
           _context.Dispose();
        }
    }
}
