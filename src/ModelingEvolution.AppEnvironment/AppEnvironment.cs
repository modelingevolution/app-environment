using RocketWelder.SDK.Types;

namespace ModelingEvolution.AppEnvironment;

/// <summary>
/// Default implementation of IEnvironment that reads from the system.
/// </summary>
public sealed class AppEnvironment : IEnvironment
{
    private readonly HostName _hostName;

    public AppEnvironment()
    {
        _hostName = HostName.Parse(System.Environment.MachineName);
    }

    public AppEnvironment(HostName hostName)
    {
        _hostName = hostName;
    }

    public HostName HostName => _hostName;
}
