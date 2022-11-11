using Repositories.Repositories;

namespace Repositories.IUnitOfWork;

public interface IUnitOfWork
{
    public CalculatedItemRepository CalculatedItems { get; set; }
    Task CompleteAsync();
    void Dispose();
}