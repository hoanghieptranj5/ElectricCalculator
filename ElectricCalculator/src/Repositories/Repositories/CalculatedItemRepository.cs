using Repositories.Models;

namespace Repositories.Repositories;

public class CalculatedItemRepository : RepositoryBase<Pricing>
{
    public CalculatedItemRepository(ApplicationDbContext context) : base(context)
    {
    }
}