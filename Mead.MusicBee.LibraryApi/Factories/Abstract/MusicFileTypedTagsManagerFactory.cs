using Mead.MusicBee.Enums;
using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Factories.Abstract;

public delegate IMusicFileTypedTagsManager MusicFileTypedTagsManagerFactory(
    Func<MetaDataType, string> getTagValue,
    Action<MetaDataType, string> setTagValue
);