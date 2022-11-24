using Repositories.Repositories;

namespace Repositories.IUnitOfWork;

public interface IUnitOfWork
{
    public PricingRepository Pricings { get; set; }
    public CalculationHistoryRepository CalculationHistories { get; set; }
    Task CompleteAsync();
    void Dispose();
}