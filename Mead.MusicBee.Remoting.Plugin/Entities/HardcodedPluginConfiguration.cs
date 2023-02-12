using Mead.MusicBee.Remoting.Plugin.Entities.Abstract;

namespace Mead.MusicBee.Remoting.Plugin.Entities;

public sealed class HardcodedPluginConfiguration : IPluginConfiguration
{
    public string Host => "localhost";
    public int Port => 38012;
}