using ElectricCalculator.Logics.CalculationHistory;
using Microsoft.AspNetCore.Mvc;

namespace ElectricCalculator.Controllers;

[Route("[Controller]")]
public class CalculationHistoryController : ControllerBase
{
    private readonly ICalculationHistoryLogic _calculationHistoryLogic;

    public CalculationHistoryController(ICalculationHistoryLogic calculationHistoryLogic)
    {
        _calculationHistoryLogic = calculationHistoryLogic;
    }

    [HttpGet]
    public async Task<IActionResult> GetHistories()
    {
        var result = await _calculationHistoryLogic.All();
        return Ok(result);
    }
}