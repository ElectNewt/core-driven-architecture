namespace CoreDrivenArchitecture.Notificator.Events;

public interface IEventNotificator
{
    Task Notify<T>(T message);
}