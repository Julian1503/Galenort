using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;

namespace Galenort.Dominio.Repositorio
{
    public interface IRepositorio<T>
    {
        Task<long> Create(T entity);

        Task Update(T entity);

        Task Delete(T entity);

        Task<IEnumerable<T>> GetAll(Func<IQueryable<T>,IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>,IIncludableQueryable<T,object>> include = null,
            bool enableTracking = true);

        Task<T> GetById(long id,
        Func<IQueryable<T>, IIncludableQueryable<T, object>> include = default,
        bool enableTracking = true);

        Task<IEnumerable<T>> GetByFilter(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
            bool enableTracking = true);
    }
}
