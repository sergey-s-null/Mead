namespace Mead.MusicBee.Remoting.Plugin.Entities.Abstract;

public interface IPluginConfiguration
{
    string Host { get; }
    int Port { get; }
}