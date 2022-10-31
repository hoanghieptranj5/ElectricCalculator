using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories.IUnitOfWork;

namespace ElectricCalculator.Controllers;

[Route("api/[Controller]")]
public class CalculatedItem : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public CalculatedItem(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _unitOfWork.CalculatedItem.All().ToListAsync();
        return Ok(result);
    }
}