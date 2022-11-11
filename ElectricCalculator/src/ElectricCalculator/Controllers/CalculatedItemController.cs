using ElectricCalculator.Logics;
using Microsoft.AspNetCore.Mvc;
using Repositories.Models;

namespace ElectricCalculator.Controllers;

[Route("api/[Controller]")]
public class CalculatedItemController : ControllerBase
{
    private readonly ICalculatedItemLogic _calculatedItemLogic;

    public CalculatedItemController(ICalculatedItemLogic calculatedItemLogic)
    {
        _calculatedItemLogic = calculatedItemLogic;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _calculatedItemLogic.GetList();
        return Ok(result);
    }

    [HttpPost("{id}")]
    public async Task<IActionResult> CreateOne(CalculatedItem item)
    {
        var ok = await _calculatedItemLogic.Add(item);
        return Ok(ok);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveOne(int id)
    {
        var result = await _calculatedItemLogic.Remove(id);
        return Ok(result);
    }
}