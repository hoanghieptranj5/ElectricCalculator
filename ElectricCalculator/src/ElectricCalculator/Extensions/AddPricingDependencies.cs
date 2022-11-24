using ElectricCalculator.Logics;
using ElectricCalculator.Logics.Calculation;
using ElectricCalculator.Logics.CalculationHistory;
using Repositories.IUnitOfWork;

namespace ElectricCalculator.Extensions;

public static class AddPricingDependencies
{
    public static IServiceCollection AddCalculationAndPricingConfigs(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IPricingLogic, PricingLogic>();
        services.AddScoped<ICalculationLogic, CalculationLogic>();
        services.AddScoped<ICalculationHistoryLogic, CalculationHistoryLogic>();

        services.AddScoped<CalculationWrapper>();
        
        return services;
    }
} 