using ElectricCalculator.Logics;
using ElectricCalculator.Logics.Calculation;
using Repositories.IUnitOfWork;

namespace ElectricCalculator.Extensions;

public static class AddPricingDependencies
{
    public static IServiceCollection AddCalculationAndPricingConfigs(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IPricingLogic, PricingLogic>();
        services.AddScoped<ICalculationLogic, CalculationLogic>();
        
        return services;
    }
} 