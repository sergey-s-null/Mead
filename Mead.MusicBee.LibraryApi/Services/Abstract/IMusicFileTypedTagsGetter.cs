using Mead.MusicBee.Enums;
using Mead.MusicBee.LibraryApi.Enums;

namespace Mead.MusicBee.LibraryApi.Services.Abstract;

public interface IMusicFileTypedTagsGetter
{
    bool GetBool(MetaDataType metaDataType);
    long GetNumber(MetaDataType metaDataType);
    DateTime GetDate(MetaDataType metaDataType);
    IReadOnlyList<string> GetEnum(MetaDataType metaDataType);
    IReadOnlyList<string> GetEncodedEnum(MetaDataType metaDataType);
    Rating GetRating(MetaDataType metaDataType);
    LoveBanRating GetLoveBanRating(MetaDataType metaDataType);
}