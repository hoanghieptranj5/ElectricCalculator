using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Repositories;

public class RepositoryBase<T> : IGenericRepository<T> where T : class
{
    private ApplicationDbContext _context;
    protected readonly DbSet<T> dbSet;

    public RepositoryBase(ApplicationDbContext context)
    {
        _context = context;
        dbSet = _context.Set<T>();
    }

    public virtual IQueryable<T> All()
    {
        return dbSet;
    }

    public virtual async Task<T> GetById(int id)
    {
        return await dbSet.FindAsync(id);
    }

    public virtual async Task<bool> Add(T entity)
    {
        await dbSet.AddAsync(entity);
        return true;
    }

    public virtual async Task<bool> Delete(int id)
    {
        var entity = await GetById(id);
        dbSet.Remove(entity);
        return true;
    }

    public Task<bool> Upsert(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual IQueryable<T> Find(Expression<Func<T, bool>> predicate)
    {
        return dbSet.Where(predicate);
    }
}