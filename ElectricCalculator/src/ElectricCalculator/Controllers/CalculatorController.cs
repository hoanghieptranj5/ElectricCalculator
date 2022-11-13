using ElectricCalculator.Logics.Calculation;
using Microsoft.AspNetCore.Mvc;

namespace ElectricCalculator.Controllers;

[Route("[Controller]")]
public class CalculatorController : ControllerBase
{
    private readonly CalculationLogic _calculationLogic;

    public CalculatorController(CalculationLogic calculationLogic)
    {
        _calculationLogic = calculationLogic;
    }

    [HttpGet("{usage}")]
    public async Task<IActionResult> Calculate(int usage)
    {
        return Ok(await _calculationLogic.Calculate(usage));
    }
}