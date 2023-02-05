using Autofac;
using Mead.MusicBee.LibraryApi.Entities;
using Mead.MusicBee.LibraryApi.Entities.Abstract;
using Mead.MusicBee.LibraryApi.Services;
using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Autofac.DependencyInjection.Extensions;

public static class ContainerBuilderExtensions
{
    public static void RegisterMusicBeeLibraryApi(this ContainerBuilder containerBuilder)
    {
        containerBuilder
            .RegisterType<MusicBeeLibraryApi>()
            .As<IMusicBeeLibraryApi>()
            .SingleInstance();

        containerBuilder
            .RegisterType<CachingReadOnlyMusicFile>()
            .As<IReadOnlyMusicFile>();
        containerBuilder
            .RegisterType<MusicFile>()
            .As<IMusicFile>();
        containerBuilder
            .RegisterType<ReadOnlyVariantField>()
            .As<IReadOnlyVariantField>();
        containerBuilder
            .RegisterType<VariantField>()
            .As<IVariantField>();

        containerBuilder
            .RegisterType<FieldValuesConverter>()
            .As<IFieldValuesConverter>()
            .SingleInstance();
    }
}