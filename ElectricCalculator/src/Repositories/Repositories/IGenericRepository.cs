using System.Linq.Expressions;

namespace Repositories.Repositories;

public interface IGenericRepository<T>
{
    IQueryable<T> All();
    Task<T> GetById(int id);
    Task<bool> Add(T entity);
    Task<bool> Delete(int id);
    Task<bool> Upsert(T entity);
    IQueryable<T> Find(Expression<Func<T, bool>> predicate);
}