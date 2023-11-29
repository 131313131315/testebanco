using Db.Data.Context;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace Db.Data.Repositories
{
    public sealed class UnitOfWorkGenerico<T> : IUnitOfWorkGenerico<T>, IDisposable where T : BaseEntityGenerico
    {
        private readonly MyContext _context;
        public UnitOfWorkGenerico(MyContext context, IRepositoryGenerico<T> repository)
        {
            _context = context;
            Repository = repository;
        }
        public IRepositoryGenerico<T> Repository { get; }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}
