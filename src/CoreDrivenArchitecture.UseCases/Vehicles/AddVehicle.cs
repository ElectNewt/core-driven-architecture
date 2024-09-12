using CoreDrivenArchitecture.Data.Entities;
using CoreDrivenArchitecture.Data.Repositories;
using CoreDrivenArchitecture.DTOs.Vehicles;
using CoreDrivenArchitecture.Notificator.Events;
using CoreDrivenArchitecture.UseCases.Mappers;
using ROP;

namespace CoreDrivenArchitecture.UseCases.Vehicles;

public class AddVehicle(IDatabaseRepository databaseRepository, 
    IEventNotificator eventNotificator)
{
    public async Task<Result<VehicleDto>> Execute(CreateVehicleRequest request)
    {
        VehicleEntity vehicleEntity =  await databaseRepository.AddVehicle(request);
        var dto = vehicleEntity.ToDto();
        await eventNotificator.Notify(dto);
        return dto;
    }
}