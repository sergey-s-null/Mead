using Autofac;
using Autofac.Core;
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

        var normalEnumFieldConverterParameter = new ResolvedParameter(
            (parameterInfo, _) => parameterInfo.Name == "enumFieldValueConverter",
            (_, context) => context
                .ResolveKeyed<IFieldValueConverter<IReadOnlyList<string>>>(EnumType.Normal)
        );
        var encodedEnumFieldConverterParameter = new ResolvedParameter(
            (parameterInfo, _) => parameterInfo.Name == "encodedEnumFieldValueConverter",
            (_, context) => context
                .ResolveKeyed<IFieldValueConverter<IReadOnlyList<string>>>(EnumType.Encoded)
        );
        var enumFieldConverterParameters = new[] { normalEnumFieldConverterParameter, encodedEnumFieldConverterParameter };

        containerBuilder
            .RegisterType<CachingReadOnlyMusicFile>()
            .WithParameters(enumFieldConverterParameters)
            .As<IReadOnlyMusicFile>();
        containerBuilder
            .RegisterType<MusicFile>()
            .WithParameters(enumFieldConverterParameters)
            .As<IMusicFile>();
        containerBuilder
            .RegisterType<ReadOnlyVariantField>()
            .WithParameters(enumFieldConverterParameters)
            .As<IReadOnlyVariantField>();
        containerBuilder
            .RegisterType<VariantField>()
            .WithParameters(enumFieldConverterParameters)
            .As<IVariantField>();

        containerBuilder
            .RegisterType<BoolFieldValueConverter>()
            .WithParameters(enumFieldConverterParameters)
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