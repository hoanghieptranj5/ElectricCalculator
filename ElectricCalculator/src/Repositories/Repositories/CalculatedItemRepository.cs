using Repositories.Models;

namespace Repositories.Repositories;

public class CalculatedItemRepository : RepositoryBase<CalculatedItem>
{
    public CalculatedItemRepository(ApplicationDbContext context) : base(context)
    {
    }
}