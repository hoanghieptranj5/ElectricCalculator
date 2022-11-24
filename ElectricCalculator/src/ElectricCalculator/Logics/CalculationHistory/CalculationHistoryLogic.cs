using Microsoft.EntityFrameworkCore;
using Repositories.IUnitOfWork;

namespace ElectricCalculator.Logics.CalculationHistory;

using CalculationHistory = Repositories.Models.CalculationHistory;

public class CalculationHistoryLogic : ICalculationHistoryLogic
{
    private readonly IUnitOfWork _unitOfWork;

    public CalculationHistoryLogic(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task Log(int totalUsage, float price)
    {
        var history = new CalculationHistory
        {
            TotalUsage = totalUsage,
            CalculatedPrice = price,
            IssuedTime = DateTime.Now
        };
        await _unitOfWork.CalculationHistories.Add(history);
        
        await _unitOfWork.CompleteAsync();
    }

    public async Task<IEnumerable<CalculationHistory>> All()
    {
        return await _unitOfWork.CalculationHistories.All().ToListAsync();
    }
}