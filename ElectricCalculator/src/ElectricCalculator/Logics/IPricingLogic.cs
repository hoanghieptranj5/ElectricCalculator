using Repositories.Models;

namespace ElectricCalculator.Logics;

public interface IPricingLogic
{
    Task<IEnumerable<Pricing>> GetList();
    Task<bool> Add(Pricing entity);
    Task<bool> Remove(int id);
}