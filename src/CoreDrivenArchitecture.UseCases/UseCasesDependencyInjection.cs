using CoreDrivenArchitecture.UseCases.Vehicles;
using Microsoft.Extensions.DependencyInjection;

namespace CoreDrivenArchitecture.UseCases;

public static class UseCasesDependencyInjection
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
        => services.AddVehicleUseCases();
    
    private static IServiceCollection AddVehicleUseCases(this IServiceCollection services)
        => services.AddScoped<VehiclesUseCases>()
            .AddScoped<AddVehicle>()
            .AddScoped<GetVehicle>();
}