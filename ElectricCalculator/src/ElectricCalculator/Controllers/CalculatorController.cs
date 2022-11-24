using ElectricCalculator.Filters;
using ElectricCalculator.Logics;
using Microsoft.AspNetCore.Mvc;

namespace ElectricCalculator.Controllers;

[Route("[Controller]")]
public class CalculatorController : ControllerBase
{
    private readonly CalculationWrapper _calculationWrapper;

    public CalculatorController(CalculationWrapper calculationWrapper)
    {
        _calculationWrapper = calculationWrapper;
    }

    [ServiceFilter(typeof(AsyncActionFilterExample))]
    [HttpGet("{usage}")]
    public async Task<IActionResult> Calculate(int usage)
    {
        return Ok(await _calculationWrapper.CalculateAsync(usage));
    }
}