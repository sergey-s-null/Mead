using Mead.MusicBee.Enums;
using Mead.MusicBee.LibraryApi.Enums;

namespace Mead.MusicBee.LibraryApi.Services.Abstract;

public interface IMusicFileTypedTagsSetter
{
    void SetBool(MetaDataType metaDataType, bool value);
    void SetNumber(MetaDataType metaDataType, long value);
    void SetDate(MetaDataType metaDataType, DateTime value);
    void SetEnum(MetaDataType metaDataType, IReadOnlyList<string> value);
    void SetEncodedEnum(MetaDataType metaDataType, IReadOnlyList<string> value);
    void SetRating(MetaDataType metaDataType, Rating value);
    void SetLoveBanRating(MetaDataType metaDataType, LoveBanRating value);
}