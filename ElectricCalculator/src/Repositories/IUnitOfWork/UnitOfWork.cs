using Repositories.Repositories;

namespace Repositories.IUnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        Pricings = new PricingRepository(context);
        CalculationHistories = new CalculationHistoryRepository(context);
    }

    public PricingRepository Pricings { get; set; }
    public CalculationHistoryRepository CalculationHistories { get; set; }

    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}