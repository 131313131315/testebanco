using Db.Data.Context;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Db.Data.Repositories
{
    public class BaseRepositoryGenerico<T> : IRepositoryGenerico<T> where T : BaseEntityGenerico
    {
        private readonly MyContext _context;
        private readonly DbSet<T> _dataset;
        public BaseRepositoryGenerico(MyContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }
        public async Task<bool> DeleteAllAsync(int id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(t => t.Id == id);
                if (result == null)
                    return false;
                _dataset.Remove(result);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _dataset.AnyAsync(p => p.Id.Equals(id));
        }
        public async Task<T> InsertAsync(T item)
        {
            try
            {

                _dataset.Add(item);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }
        public T InsertAsyncAdd(T item)
        {
            try
            {
                _dataset.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }

        public async Task<T> SelectAsync(int id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IQueryable<T> GetDataSet()
        {
            return _context.Set<T>();  //Verificar AsNoTracking 
        }

        public async Task<IEnumerable<T>> SelectAsync()
        {
            try
            {
                return await _dataset.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<T> UpdateListAdd(IEnumerable<T> item)
        {
            try
            {
                _dataset.UpdateRange(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }
        public async Task<IEnumerable<T>> UpdateListAsync(IEnumerable<T> item)
        {
            try
            {
                _dataset.UpdateRange(item);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }
        public async Task<int> RetornaSequencia(string nome)
        {
            try
            {

                var commandText = "SELECT @result = (NEXT VALUE FOR " + nome + ")";

                var name = new SqlParameter("@result", System.Data.SqlDbType.Int)
                {
                    Direction = System.Data.ParameterDirection.Output
                };
                await _context.Database.ExecuteSqlRawAsync(commandText, name);

                return (int)name.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int RetornaSequenciaSincrono(string nome)
        {
            try
            {

                var commandText = "SELECT @result = (NEXT VALUE FOR " + nome + ")";

                var name = new SqlParameter("@result", System.Data.SqlDbType.Int)
                {
                    Direction = System.Data.ParameterDirection.Output
                };
                _context.Database.ExecuteSqlRaw(commandText, name);

                return (int)name.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CriarSequencia(string nome, int ultimo)
        {
            try
            {
                var commandText = "CREATE SEQUENCE " + nome + " START WITH " + ultimo + " INCREMENT BY 1";

                _context.Database.ExecuteSqlRaw(commandText);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool VerificaExisteSequencia(string nome)
        {
            try
            {
                var commandText = "SELECT @valor = (SELECT CONVERT(INT, current_value) FROM sys.sequences WHERE name = '" + nome + "')";

                var valor = new SqlParameter("@valor", System.Data.SqlDbType.Int)
                {
                    Direction = System.Data.ParameterDirection.Output,
                    IsNullable = true
                };

                _context.Database.ExecuteSqlRaw(commandText, valor);

                return valor.Value != DBNull.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(t => t.Id == id);
                if (result == null)
                    return false;

                _dataset.Update(result);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> DeleteList(IEnumerable<T> item)
        {
            try
            {
                _dataset.RemoveRange(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public async Task<IEnumerable<T>> SelectWhereAsync(Expression<Func<T, bool>> where)
        {
            try
            {
                return await _dataset.Where(where).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<T> SelectWhereDefaultAsync(Expression<Func<T, bool>> where)
        {
            try
            {
                return await _dataset.Where(where).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();  //Verificar AsNoTracking 
        }
        public async Task<IEnumerable<T>> InsertListAsync(IEnumerable<T> item)
        {
            try
            {
                _dataset.AddRange(item);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }

        public IEnumerable<T> InsertListAsyncAdd(IEnumerable<T> item)
        {
            try
            {
                var result = item.ToList();

                _dataset.AddRange(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }
        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(t => t.Id == item.Id);
                if (result == null)
                    return null;

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }
    }
}
