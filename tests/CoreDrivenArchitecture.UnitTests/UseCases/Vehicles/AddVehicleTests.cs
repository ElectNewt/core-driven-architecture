using CoreDrivenArchitecture.Data.Entities;
using CoreDrivenArchitecture.Data.Repositories;
using CoreDrivenArchitecture.DTOs.Vehicles;
using CoreDrivenArchitecture.Notificator.Events;
using CoreDrivenArchitecture.UseCases.Vehicles;
using Moq;

namespace CoreDrivenArchitecture.UnitTests.UseCases.Vehicles;

public class AddVehicleTests
{
    private class TestState
    {
        public Mock<IDatabaseRepository> DatabaseRepository { get; set; }
        public AddVehicle Subject { get; set; }
        public Mock<IEventNotificator> EventNotificator { get; set; }

        public TestState()
        {
            DatabaseRepository = new Mock<IDatabaseRepository>();
            EventNotificator = new Mock<IEventNotificator>();
            Subject = new AddVehicle(DatabaseRepository.Object, EventNotificator.Object);
        }
    }

    [Fact]
    public async Task WhenVehicleRequestHasCorrectData_thenInserted()
    {
        TestState state = new();
        string make = "opel";
        string name = "vehicle1";
        int id = 1;
        state.DatabaseRepository.Setup(x => x
                .AddVehicle(It.IsAny<CreateVehicleRequest>()))
            .ReturnsAsync(new VehicleEntity() { Id = id, Make = make, Name = name });


        var result = await state.Subject
            .Execute(new CreateVehicleRequest() { Make = make, Name = name });

        Assert.True(result.Success);
        Assert.Equal(make, result.Value.Make);
        Assert.Equal(id, result.Value.Id);
        Assert.Equal(name, result.Value.Name);

        state.EventNotificator.Verify(a =>
            a.Notify(result.Value), Times.Once);
    }
}