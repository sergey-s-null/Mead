using Autofac;
using Mead.MusicBee.Api.Services;
using Mead.MusicBee.Api.Services.Abstract;
using Mead.MusicBee.Services;

namespace Mead.MusicBee.Api.Autofac.DependencyInjection.Extensions;

public static class ContainerBuilderExtensions
{
    public static void RegisterMusicBeeApi(
        this ContainerBuilder builder,
        MusicBeeApiMemoryContainer musicBeeApiMemoryContainer)
    {
        builder
            .RegisterType<MusicBeeApiMemoryContainerWrapper>()
            .WithParameter(TypedParameter.From(musicBeeApiMemoryContainer))
            .As<IMusicBeeApi>()
            .SingleInstance();
    }

    public static void RegisterMusicBeeApi(this ContainerBuilder builder)
    {
        builder
            .RegisterType<MusicBeeApiMemoryContainerWrapper>()
            .As<IMusicBeeApi>()
            .SingleInstance();
    }
}