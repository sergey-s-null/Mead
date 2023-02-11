using Mead.MusicBee.Enums;
using Mead.MusicBee.LibraryApi.Enums;
using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Services;

public sealed class MusicFileTypedTagsGetter : IMusicFileTypedTagsGetter
{
    private readonly Func<MetaDataType, string> _getTagValue;

    private readonly IFieldValueConverter<bool> _boolFieldValueConverter;
    private readonly IFieldValueConverter<long> _numberFieldValueConverter;
    private readonly IFieldValueConverter<DateTime> _dateFieldValueConverter;
    private readonly IFieldValueConverter<IReadOnlyList<string>> _enumFieldValueConverter;
    private readonly IFieldValueConverter<IReadOnlyList<string>> _encodedEnumFieldValueConverter;
    private readonly IFieldValueConverter<Rating> _ratingFieldValueConverter;
    private readonly IFieldValueConverter<LoveBanRating> _loveBanRatingFieldValueConverter;

    public MusicFileTypedTagsGetter(
        Func<MetaDataType, string> getTagValue,
        IFieldValueConverter<bool> boolFieldValueConverter,
        IFieldValueConverter<long> numberFieldValueConverter,
        IFieldValueConverter<DateTime> dateFieldValueConverter,
        IFieldValueConverter<IReadOnlyList<string>> enumFieldValueConverter,
        IFieldValueConverter<IReadOnlyList<string>> encodedEnumFieldValueConverter,
        IFieldValueConverter<Rating> ratingFieldValueConverter,
        IFieldValueConverter<LoveBanRating> loveBanRatingFieldValueConverter)
    {
        _getTagValue = getTagValue;
        _boolFieldValueConverter = boolFieldValueConverter;
        _numberFieldValueConverter = numberFieldValueConverter;
        _dateFieldValueConverter = dateFieldValueConverter;
        _enumFieldValueConverter = enumFieldValueConverter;
        _encodedEnumFieldValueConverter = encodedEnumFieldValueConverter;
        _ratingFieldValueConverter = ratingFieldValueConverter;
        _loveBanRatingFieldValueConverter = loveBanRatingFieldValueConverter;
    }


    public bool GetBool(MetaDataType metaDataType)
    {
        return _boolFieldValueConverter.ConvertFromString(_getTagValue(metaDataType));
    }

    public long GetNumber(MetaDataType metaDataType)
    {
        return _numberFieldValueConverter.ConvertFromString(_getTagValue(metaDataType));
    }

    public DateTime GetDate(MetaDataType metaDataType)
    {
        return _dateFieldValueConverter.ConvertFromString(_getTagValue(metaDataType));
    }

    public IReadOnlyList<string> GetEnum(MetaDataType metaDataType)
    {
        return _enumFieldValueConverter.ConvertFromString(_getTagValue(metaDataType));
    }

    public IReadOnlyList<string> GetEncodedEnum(MetaDataType metaDataType)
    {
        return _encodedEnumFieldValueConverter.ConvertFromString(_getTagValue(metaDataType));
    }

    public Rating GetRating(MetaDataType metaDataType)
    {
        return _ratingFieldValueConverter.ConvertFromString(_getTagValue(metaDataType));
    }

    public LoveBanRating GetLoveBanRating(MetaDataType metaDataType)
    {
        return _loveBanRatingFieldValueConverter.ConvertFromString(_getTagValue(metaDataType));
    }
}