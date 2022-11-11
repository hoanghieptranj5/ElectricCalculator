using ElectricCalculator.Logics;
using Microsoft.AspNetCore.Mvc;
using Repositories.Models;

namespace ElectricCalculator.Controllers;

[Route("api/[Controller]")]
public class PricingController : ControllerBase
{
    private readonly IPricingLogic _pricingLogic;

    public PricingController(IPricingLogic pricingLogic)
    {
        _pricingLogic = pricingLogic;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _pricingLogic.GetList();
        return Ok(result);
    }

    [HttpPost("{id}")]
    public async Task<IActionResult> CreateOne(Pricing item)
    {
        var ok = await _pricingLogic.Add(item);
        return Ok(ok);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveOne(int id)
    {
        var result = await _pricingLogic.Remove(id);
        return Ok(result);
    }
}