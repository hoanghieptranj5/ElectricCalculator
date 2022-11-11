using Repositories.Models;

namespace ElectricCalculator.Logics;

public interface IPricingLogic
{
    Task<IEnumerable<Pricing>> GetList();
    Task<Pricing> GetOneById(int id);
    Task<bool> Add(Pricing entity);
    Task<bool> Remove(int id);
}