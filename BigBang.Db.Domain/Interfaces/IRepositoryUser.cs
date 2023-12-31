﻿using Db.Domain.Entities.Cadastros.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces
{
    public interface IRepositoryUser<T> where T : ApplicationUser
    {
        Task<T> SelectAsync(int id);
        Task<IEnumerable<T>> SelectWhereAsync(Expression<Func<T, bool>> where);
        IQueryable<T> GetDataSet();
        Task<T> SelectWhereDefaultAsync(Expression<Func<T, bool>> where);
    }
}

