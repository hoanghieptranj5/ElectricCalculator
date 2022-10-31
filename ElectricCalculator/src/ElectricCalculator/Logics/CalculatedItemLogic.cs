using Repositories.IUnitOfWork;
using Repositories.Models;

namespace ElectricCalculator.Logics;

public class CalculatedItemLogic : ICalculatedItemLogic
{
    private readonly IUnitOfWork _unitOfWork;

    public CalculatedItemLogic(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<CalculatedItem>> GetList()
    {
        return _unitOfWork.CalculatedItem.All().AsEnumerable();
    }

    public async Task<bool> Add(CalculatedItem entity)
    {
        var result = await _unitOfWork.CalculatedItem.Add(entity);
        await _unitOfWork.CompleteAsync();
        return result;
    }
}