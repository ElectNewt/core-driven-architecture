namespace CoreDrivenArchitecture.DTOs.Vehicles;

public class CreateVehicleRequest
{
    public required string Name { get; set; }
    public required string Make { get; set; }
}