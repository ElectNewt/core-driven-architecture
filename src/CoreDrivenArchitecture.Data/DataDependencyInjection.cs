using CoreDrivenArchitecture.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CoreDrivenArchitecture.Data;

public static class DataDependencyInjection
{
    public static IServiceCollection AddData(this IServiceCollection services)
        => services.AddScoped<IDatabaseRepository, DatabaseRepository>();

}