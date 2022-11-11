using Repositories.Models;

namespace Repositories.Repositories;

public class PricingRepository : RepositoryBase<Pricing>
{
    public PricingRepository(ApplicationDbContext context) : base(context)
    {
    }
}