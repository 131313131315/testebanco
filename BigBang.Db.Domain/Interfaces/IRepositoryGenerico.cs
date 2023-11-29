using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepositoryGenerico<T> where T : BaseEntityGenerico
    {
        Task<T> SelectAsync(int id);
        Task<IEnumerable<T>> SelectAsync();
        Task<bool> ExistAsync(int id);
        IQueryable<T> GetAll();
        Task<IEnumerable<T>> InsertListAsync(IEnumerable<T> item);
        Task<bool> DeleteList(IEnumerable<T> item);
        IQueryable<T> GetDataSet();
        Task<IEnumerable<T>> SelectWhereAsync(Expression<Func<T, bool>> where);
        Task<T> SelectWhereDefaultAsync(Expression<Func<T, bool>> where);
        Task<int> RetornaSequencia(string nome);
        int RetornaSequenciaSincrono(string nome);
        Task<T> InsertAsync(T item);
        T InsertAsyncAdd(T item);
        IEnumerable<T> InsertListAsyncAdd(IEnumerable<T> item);
        Task<IEnumerable<T>> UpdateListAsync(IEnumerable<T> item);
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAllAsync(int id);
        void CriarSequencia(string nome, int ultimo);
        bool VerificaExisteSequencia(string nome);
        IEnumerable<T> UpdateListAdd(IEnumerable<T> item);
    }
}
