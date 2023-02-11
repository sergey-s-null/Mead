using Autofac;
using Grpc.Core;
using Mead.MusicBee.Entities;
using Mead.MusicBee.Enums;
using Mead.MusicBee.Remoting.Plugin;
using Mead.MusicBee.Remoting.Plugin.Entities.Abstract;
using Mead.MusicBee.Services;

// ReSharper disable once CheckNamespace
namespace MusicBeePlugin;

public sealed class Plugin : PluginBase
{
    private const short PluginInfoVersion = 1;
    private const short MinInterfaceVersion = 41;
    private const short MinApiRevision = 53;

    private IPluginConfiguration? _pluginConfiguration;
    private Func<MusicBeeApiServiceImpl>? _musicBeeApiServiceFactory;
    private Server? _server;

    protected override void OnMusicBeeApiProvided(MusicBeeApiMemoryContainer musicBeeApi)
    {
        var container = PluginContainer.Create();

        _pluginConfiguration = container.Resolve<IPluginConfiguration>();
        _musicBeeApiServiceFactory = container.Resolve<Func<MusicBeeApiServiceImpl>>();
    }

    protected override PluginInfo GetPluginInfo()
    {
        return new PluginInfo
        {
            PluginInfoVersion = PluginInfoVersion,
            Name = "Remote Api Server",
            Description = "Grpc server that provide remote access to MusicBee Api.",
            Author = "Sergey Semenov",
            TargetApplication = "",
            Type = PluginType.General,
            VersionMajor = 1,
            VersionMinor = 0,
            Revision = 1,
            MinInterfaceVersion = MinInterfaceVersion,
            MinApiRevision = MinApiRevision,
            ReceiveNotifications = ReceiveNotificationFlags.StartupOnly,
            ConfigurationPanelHeight = 0
        };
    }

    public override void ReceiveNotification(string sourceFileUrl, NotificationType type)
    {
        if (type == NotificationType.PluginStartup)
        {
            StartServerIfNotStarted();
        }
        else if (type == NotificationType.ShutdownStarted)
        {
            StopServerIfStarted();
        }
    }

    public override void Close(PluginCloseReason reason)
    {
        StopServerIfStarted();
    }

    public override void Uninstall()
    {
        StopServerIfStarted();
    }

    private void StartServerIfNotStarted()
    {
        if (_server is not null)
        {
            return;
        }

        _server = CreateServer();
        _server.Start();
    }

    private Server CreateServer()
    {
        if (_musicBeeApiServiceFactory is null)
        {
            throw new NullReferenceException($"{nameof(_musicBeeApiServiceFactory)} is null.");
        }

        if (_pluginConfiguration is null)
        {
            throw new NullReferenceException($"{nameof(_pluginConfiguration)} is null.");
        }

        return new Server
        {
            Ports =
            {
                {
                    _pluginConfiguration.Host,
                    _pluginConfiguration.Port,
                    ServerCredentials.Insecure
                }
            },
            Services =
            {
                MusicBeeApiService.BindService(_musicBeeApiServiceFactory())
            },
        };
    }

    private void StopServerIfStarted()
    {
        if (_server is null)
        {
            return;
        }

        _server.ShutdownAsync().Wait();
        _server = null;
    }
}