namespace ElectricCalculator.Logics.CalculationHistory;

public interface ICalculationHistoryLogic
{
    public Task Log(int totalUsage, float price);
    public Task<IEnumerable<Repositories.Models.CalculationHistory>> All();
}