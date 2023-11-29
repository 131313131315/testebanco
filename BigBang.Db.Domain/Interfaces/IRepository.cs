using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> InsertAsync(T item);
        T InsertAsyncAdd(T item);
        Task<IEnumerable<T>> InsertListAsync(IEnumerable<T> item);
        IEnumerable<T> InsertListAsyncAdd(IEnumerable<T> item);
        Task<IEnumerable<T>> UpdateListAsync(IEnumerable<T> item);
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(int id);
        Task<bool> DeleteAllAsync(int id);
        Task<bool> DeleteList(IEnumerable<T> item);
        Task<T> SelectAsync(int id);
        Task<IEnumerable<T>> SelectAsync();
        Task<bool> ExistAsync(int id);
        Task<IEnumerable<T>> SelectWhereAsync(Expression<Func<T, bool>> where);
        IQueryable<T> GetDataSet();
        Task<T> SelectWhereDefaultAsync(Expression<Func<T, bool>> where);
        Task<int> RetornaSequencia(string nome);
        int RetornaSequenciaSincrono(string nome);
        void CriarSequencia(string nome, int ultimo);
        bool VerificaExisteSequencia(string nome);
    }
}
