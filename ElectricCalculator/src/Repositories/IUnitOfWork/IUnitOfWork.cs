using Microsoft.EntityFrameworkCore;
using Repositories.Models;
using Repositories.Repositories;

namespace Repositories.IUnitOfWork;

public interface IUnitOfWork
{
    public CalculatedItemRepository CalculatedItem { get; set; }
    Task CompleteAsync();
    void Dispose();
}