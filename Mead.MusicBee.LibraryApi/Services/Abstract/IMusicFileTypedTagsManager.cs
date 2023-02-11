using Mead.MusicBee.Enums;
using Mead.MusicBee.LibraryApi.Enums;

namespace Mead.MusicBee.LibraryApi.Services.Abstract;

public interface IMusicFileTypedTagsManager
{
    bool GetBool(MetaDataType metaDataType);
    void SetBool(MetaDataType metaDataType, bool value);

    long GetNumber(MetaDataType metaDataType);
    void SetNumber(MetaDataType metaDataType, long value);

    DateTime GetDate(MetaDataType metaDataType);
    void SetDate(MetaDataType metaDataType, DateTime value);

    IReadOnlyList<string> GetEnum(MetaDataType metaDataType);
    void SetEnum(MetaDataType metaDataType, IReadOnlyList<string> value);

    IReadOnlyList<string> GetEncodedEnum(MetaDataType metaDataType);
    void SetEncodedEnum(MetaDataType metaDataType, IReadOnlyList<string> value);

    Rating GetRating(MetaDataType metaDataType);
    void SetRating(MetaDataType metaDataType, Rating value);

    LoveBanRating GetLoveBanRating(MetaDataType metaDataType);
    void SetLoveBanRating(MetaDataType metaDataType, LoveBanRating value);
}