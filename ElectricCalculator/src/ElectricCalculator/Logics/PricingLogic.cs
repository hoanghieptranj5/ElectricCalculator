using Microsoft.EntityFrameworkCore;
using Repositories.IUnitOfWork;
using Repositories.Models;

namespace ElectricCalculator.Logics;

public class PricingLogic : IPricingLogic
{
    private readonly IUnitOfWork _unitOfWork;

    public PricingLogic(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Pricing>> GetList()
    {
        return await _unitOfWork.Pricings.All().ToListAsync();
    }

    public async Task<Pricing> GetOneById(int id)
    {
        return await _unitOfWork.Pricings.GetById(id);
    }

    public async Task<bool> Add(Pricing entity)
    {
        var result = await _unitOfWork.Pricings.Add(entity);
        await _unitOfWork.CompleteAsync();
        return result;
    }

    public async Task<bool> Remove(int id)
    {
        var result = await _unitOfWork.Pricings.Delete(id);
        await _unitOfWork.CompleteAsync();
        return result;
    }
}