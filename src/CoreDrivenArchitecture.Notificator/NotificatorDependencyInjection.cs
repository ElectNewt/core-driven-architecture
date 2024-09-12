using CoreDrivenArchitecture.Notificator.Events;
using Microsoft.Extensions.DependencyInjection;

namespace CoreDrivenArchitecture.Notificator;

public static class NotificatorDependencyInjection
{
    public static IServiceCollection AddNotificator(this IServiceCollection services)
        => services.AddScoped<IEventNotificator, RabbitMQClient>();
}