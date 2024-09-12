namespace CoreDrivenArchitecture.Notificator.Events;

public class RabbitMQClient : IEventNotificator
{
    public Task Notify<T>(T message)
    {
        throw new NotImplementedException();
    }
}