using Mead.MusicBee.Enums;
using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Factories.Abstract;

public delegate IMusicFileTypedTagsGetter MusicFileTypedTagsGetterFactory(
    Func<MetaDataType, string> getTagValue
);