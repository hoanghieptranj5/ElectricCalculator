using Repositories.Repositories;

namespace Repositories.IUnitOfWork;

public interface IUnitOfWork
{
    public PricingRepository Pricings { get; set; }
    Task CompleteAsync();
    void Dispose();
}