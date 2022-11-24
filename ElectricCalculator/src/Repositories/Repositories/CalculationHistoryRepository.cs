using Repositories.Models;

namespace Repositories.Repositories;

public class CalculationHistoryRepository : RepositoryBase<CalculationHistory>
{
    public CalculationHistoryRepository(ApplicationDbContext context) : base(context)
    {
    }
}