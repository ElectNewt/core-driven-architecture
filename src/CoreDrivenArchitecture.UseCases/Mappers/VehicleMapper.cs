using CoreDrivenArchitecture.Data.Entities;
using CoreDrivenArchitecture.DTOs.Vehicles;

namespace CoreDrivenArchitecture.UseCases.Mappers;

public static class VehicleMapper
{
    public static VehicleDto ToDto(this VehicleEntity vehicleEntity)
        => new VehicleDto
        {
            Id = vehicleEntity.Id,
            Name = vehicleEntity.Name,
            Make = vehicleEntity.Make
        };
}