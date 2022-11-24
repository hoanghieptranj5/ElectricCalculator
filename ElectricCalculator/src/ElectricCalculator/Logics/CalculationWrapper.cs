using ElectricCalculator.Logics.Calculation;
using ElectricCalculator.Logics.CalculationHistory;
using ElectricCalculator.Models;

namespace ElectricCalculator.Logics;

public class CalculationWrapper
{
    private readonly ICalculationLogic _calculationLogic;
    private readonly ICalculationHistoryLogic _calculationHistoryLogic;

    public CalculationWrapper(ICalculationLogic calculationLogic, ICalculationHistoryLogic calculationHistoryLogic)
    {
        _calculationLogic = calculationLogic;
        _calculationHistoryLogic = calculationHistoryLogic;
    }

    public async Task<CalculatedModel> CalculateAsync(int usage)
    {
        var result = await _calculationLogic.CalculateAsync(usage);
        await _calculationHistoryLogic.Log((int)result.Usage, result.Total);

        return result;
    }
}