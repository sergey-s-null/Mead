using Mead.MusicBee.LibraryApi.Entities.Abstract;

namespace Mead.MusicBee.LibraryApi.Factories.Abstract;

public delegate IReadOnlyVariantField ReadOnlyVariantFieldFactory(Func<string> getTagValue);