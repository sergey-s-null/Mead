using Autofac;
using Mead.MusicBee.LibraryApi.Autofac.DependencyInjection.Enums;
using Mead.MusicBee.LibraryApi.Entities;
using Mead.MusicBee.LibraryApi.Entities.Abstract;
using Mead.MusicBee.LibraryApi.Enums;
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
            .RegisterType<BoolFieldValueConverter>()
            .As<IFieldValueConverter<bool>>()
            .SingleInstance();
        containerBuilder
            .RegisterType<NumberFieldValueConverter>()
            .As<IFieldValueConverter<long>>()
            .SingleInstance();
        containerBuilder
            .RegisterType<DateFieldValueConverter>()
            .As<IFieldValueConverter<DateTime>>()
            .SingleInstance();
        containerBuilder
            .RegisterType<EnumFieldValueConverter>()
            .As<IFieldValueConverter<IReadOnlyList<string>>>()
            .Keyed<EnumType>(EnumType.Normal)
            .SingleInstance();
        containerBuilder
            .RegisterType<EncodedEnumFieldValueConverter>()
            .As<IFieldValueConverter<IReadOnlyList<string>>>()
            .Keyed<EnumType>(EnumType.Encoded)
            .SingleInstance();
        containerBuilder
            .RegisterType<RatingFieldValueConverter>()
            .As<IFieldValueConverter<Rating>>()
            .SingleInstance();
        containerBuilder
            .RegisterType<LoveBanRatingFieldValueConverter>()
            .As<IFieldValueConverter<LoveBanRating>>()
            .SingleInstance();
    }
}