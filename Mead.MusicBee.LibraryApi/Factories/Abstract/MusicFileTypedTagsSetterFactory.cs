using Mead.MusicBee.Enums;
using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Factories.Abstract;

public delegate IMusicFileTypedTagsSetter MusicFileTypedTagsSetterFactory(
    Action<MetaDataType, string> setTagValue
);