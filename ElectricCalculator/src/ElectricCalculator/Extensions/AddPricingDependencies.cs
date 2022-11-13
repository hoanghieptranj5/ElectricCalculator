using ElectricCalculator.Logics;
using ElectricCalculator.Logics.Calculation;
using Repositories.IUnitOfWork;

namespace ElectricCalculator.Extensions;

public static class AddPricingDependencies
{
    public static IServiceCollection AddPricings(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IPricingLogic, PricingLogic>();
        services.AddScoped<CalculationLogic>();
        
        return services;
    }
} 