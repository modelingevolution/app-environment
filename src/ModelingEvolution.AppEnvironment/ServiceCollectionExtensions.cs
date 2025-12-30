using Microsoft.Extensions.DependencyInjection;

namespace ModelingEvolution.AppEnvironment;

/// <summary>
/// Extension methods for registering IEnvironment in DI container.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds IEnvironment as a singleton using the default AppEnvironment implementation.
    /// </summary>
    public static IServiceCollection AddAppEnvironment(this IServiceCollection services)
    {
        services.AddSingleton<IEnvironment, AppEnvironment>();
        return services;
    }

    /// <summary>
    /// Adds IEnvironment as a singleton with a custom implementation.
    /// </summary>
    public static IServiceCollection AddAppEnvironment<T>(this IServiceCollection services)
        where T : class, IEnvironment
    {
        services.AddSingleton<IEnvironment, T>();
        return services;
    }
}
