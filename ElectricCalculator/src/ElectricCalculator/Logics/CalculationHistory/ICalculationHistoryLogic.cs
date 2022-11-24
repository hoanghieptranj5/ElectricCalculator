namespace ElectricCalculator.Logics.CalculationHistory;

public interface ICalculationHistoryLogic
{
    Task Log(Repositories.Models.CalculationHistory history);
}