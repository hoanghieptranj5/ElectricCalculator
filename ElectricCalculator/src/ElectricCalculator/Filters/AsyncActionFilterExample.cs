using Microsoft.AspNetCore.Mvc.Filters;

namespace ElectricCalculator.Filters;

public class AsyncActionFilterExample : IAsyncActionFilter
{
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        Console.WriteLine("Before action executed");
        await next();
        Console.WriteLine("After action executed");
    }
}