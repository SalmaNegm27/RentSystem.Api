using Microsoft.EntityFrameworkCore.Storage;
using RentSystem.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentSystem.Infrasturcture.InfrastructureBases
{
    public interface IGenericRepositoryAsync<T> where T : class
    {
        Task<T> FindByExpression(Expression<Func<T, bool>> match, Expression<Func<T, object>>?[]? includes = null);
        Task<IEnumerable<T>> FindAllByExpression(Expression<Func<T, bool>> match, Expression<Func<T, object>>?[]? includes = null, int? take = null, int? skip = null,
            Expression<Func<T, object>>? orderBy = null, string OrderByDirection = OrderBy.Ascending);

        Task DeleteRangeAsync(ICollection<T> entities);
        Task<T> GetByIdAsync(int id);
        Task SaveChangesAsync();
        IDbContextTransaction BeginTransaction();
        void Commit();
        void RollBack();
        IQueryable<T> GetTableNoTracking();
        IQueryable<T> GetTableAsTracking();
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(ICollection<T> entities);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(ICollection<T> entities);
        Task DeleteAsync(T entity);
    }
}
