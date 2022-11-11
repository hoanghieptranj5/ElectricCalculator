using Repositories.Repositories;

namespace Repositories.IUnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        CalculatedItems = new CalculatedItemRepository(context);
    }

    public CalculatedItemRepository CalculatedItems { get; set; }

    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}