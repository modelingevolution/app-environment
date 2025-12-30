using RocketWelder.SDK.Types;

namespace ModelingEvolution.AppEnvironment;

/// <summary>
/// Provides environment information for the application.
/// </summary>
public interface IEnvironment
{
    /// <summary>
    /// Gets the hostname of the current machine.
    /// </summary>
    HostName HostName { get; }
}
