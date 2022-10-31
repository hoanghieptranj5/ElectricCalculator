using Repositories.Models;

namespace ElectricCalculator.Logics;

public interface ICalculatedItemLogic
{
    Task<IEnumerable<CalculatedItem>> GetList();
    Task<bool> Add(CalculatedItem entity);
}