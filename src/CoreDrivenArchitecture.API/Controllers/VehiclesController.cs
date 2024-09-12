using CoreDrivenArchitecture.DTOs.Vehicles;
using CoreDrivenArchitecture.UseCases.Vehicles;
using Microsoft.AspNetCore.Mvc;
using ROP.APIExtensions;

namespace CoreDrivenArchitecture.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VehiclesController(VehiclesUseCases vehicles)
{
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
        => await vehicles.GetVehicle.Execute(id)
            .ToValueOrProblemDetails();
    
    [HttpPost]
    public async Task<IActionResult> Post(CreateVehicleRequest request)
        => await vehicles.AddVehicle.Execute(request)
            .ToValueOrProblemDetails();
}