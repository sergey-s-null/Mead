using Autofac;
using Mead.MusicBee.Api.Autofac.DependencyInjection.Extensions;
using Mead.MusicBee.Remoting.Plugin.Entities;
using Mead.MusicBee.Remoting.Plugin.Entities.Abstract;
using Mead.MusicBee.Services;

namespace Mead.MusicBee.Remoting.Plugin;

public static class PluginContainer
{
    public static IContainer Create(MusicBeeApiMemoryContainer musicBeeApiMemoryContainer)
    {
        var builder = new ContainerBuilder();

        builder.RegisterMusicBeeApi(musicBeeApiMemoryContainer);

        builder
            .RegisterType<HardcodedPluginConfiguration>()
            .As<IPluginConfiguration>()
            .SingleInstance();

        builder
            .RegisterType<MusicBeeApiServiceImpl>()
            .AsSelf();

        return builder.Build();
    }
}