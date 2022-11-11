using Microsoft.EntityFrameworkCore;
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
        return await _unitOfWork.CalculatedItems.All().ToListAsync();
    }

    public async Task<bool> Add(CalculatedItem entity)
    {
        var result = await _unitOfWork.CalculatedItems.Add(entity);
        await _unitOfWork.CompleteAsync();
        return result;
    }

    public async Task<bool> Remove(int id)
    {
        var result = await _unitOfWork.CalculatedItems.Delete(id);
        await _unitOfWork.CompleteAsync();
        return result;
    }
}