using ElectricCalculator.Models;

namespace ElectricCalculator.Logics.Calculation;

public interface ICalculationLogic
{
    public Task<CalculatedModel> CalculateAsync(int usage);
}