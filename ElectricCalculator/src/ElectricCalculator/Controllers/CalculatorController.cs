using ElectricCalculator.Filters;
using ElectricCalculator.Logics.Calculation;
using Microsoft.AspNetCore.Mvc;

namespace ElectricCalculator.Controllers;

[Route("[Controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ICalculationLogic _calculationLogic;

    public CalculatorController(CalculationLogic calculationLogic)
    {
        _calculationLogic = calculationLogic;
    }

    [ServiceFilter(typeof(AsyncActionFilterExample))]
    [HttpGet("{usage}")]
    public async Task<IActionResult> Calculate(int usage)
    {
        return Ok(await _calculationLogic.CalculateAsync(usage));
    }
}