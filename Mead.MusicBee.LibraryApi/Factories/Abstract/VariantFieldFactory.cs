using Mead.MusicBee.LibraryApi.Entities.Abstract;

namespace Mead.MusicBee.LibraryApi.Factories.Abstract;

public delegate IVariantField VariantFieldFactory(
    Func<string> getTagValue,
    Action<string> setTagValue
);