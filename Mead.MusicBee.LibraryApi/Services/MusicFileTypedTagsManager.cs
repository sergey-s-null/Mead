using Mead.MusicBee.Enums;
using Mead.MusicBee.LibraryApi.Enums;
using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Services;

public sealed class MusicFileTypedTagsManager : IMusicFileTypedTagsManager
{
    private readonly Func<MetaDataType, string> _getTagValue;
    private readonly Action<MetaDataType, string> _setTagValue;

    private readonly IFieldValueConverter<bool> _boolFieldValueConverter;
    private readonly IFieldValueConverter<long> _numberFieldValueConverter;
    private readonly IFieldValueConverter<DateTime> _dateFieldValueConverter;
    private readonly IFieldValueConverter<IReadOnlyList<string>> _enumFieldValueConverter;
    private readonly IFieldValueConverter<IReadOnlyList<string>> _encodedEnumFieldValueConverter;
    private readonly IFieldValueConverter<Rating> _ratingFieldValueConverter;
    private readonly IFieldValueConverter<LoveBanRating> _loveBanRatingFieldValueConverter;

    public MusicFileTypedTagsManager(
        Func<MetaDataType, string> getTagValue,
        Action<MetaDataType, string> setTagValue,
        IFieldValueConverter<bool> boolFieldValueConverter,
        IFieldValueConverter<long> numberFieldValueConverter,
        IFieldValueConverter<DateTime> dateFieldValueConverter,
        IFieldValueConverter<IReadOnlyList<string>> enumFieldValueConverter,
        IFieldValueConverter<IReadOnlyList<string>> encodedEnumFieldValueConverter,
        IFieldValueConverter<Rating> ratingFieldValueConverter,
        IFieldValueConverter<LoveBanRating> loveBanRatingFieldValueConverter)
    {
        _getTagValue = getTagValue;
        _setTagValue = setTagValue;
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

    public void SetBool(MetaDataType metaDataType, bool value)
    {
        _setTagValue(metaDataType, _boolFieldValueConverter.ConvertToString(value));
    }

    public long GetNumber(MetaDataType metaDataType)
    {
        return _numberFieldValueConverter.ConvertFromString(_getTagValue(metaDataType));
    }

    public void SetNumber(MetaDataType metaDataType, long value)
    {
        _setTagValue(metaDataType, _numberFieldValueConverter.ConvertToString(value));
    }

    public DateTime GetDate(MetaDataType metaDataType)
    {
        return _dateFieldValueConverter.ConvertFromString(_getTagValue(metaDataType));
    }

    public void SetDate(MetaDataType metaDataType, DateTime value)
    {
        _setTagValue(metaDataType, _dateFieldValueConverter.ConvertToString(value));
    }

    public IReadOnlyList<string> GetEnum(MetaDataType metaDataType)
    {
        return _enumFieldValueConverter.ConvertFromString(_getTagValue(metaDataType));
    }

    public void SetEnum(MetaDataType metaDataType, IReadOnlyList<string> value)
    {
        _setTagValue(metaDataType, _enumFieldValueConverter.ConvertToString(value));
    }

    public IReadOnlyList<string> GetEncodedEnum(MetaDataType metaDataType)
    {
        return _encodedEnumFieldValueConverter.ConvertFromString(_getTagValue(metaDataType));
    }

    public void SetEncodedEnum(MetaDataType metaDataType, IReadOnlyList<string> value)
    {
        _setTagValue(metaDataType, _encodedEnumFieldValueConverter.ConvertToString(value));
    }

    public Rating GetRating(MetaDataType metaDataType)
    {
        return _ratingFieldValueConverter.ConvertFromString(_getTagValue(metaDataType));
    }

    public void SetRating(MetaDataType metaDataType, Rating value)
    {
        _setTagValue(metaDataType, _ratingFieldValueConverter.ConvertToString(value));
    }

    public LoveBanRating GetLoveBanRating(MetaDataType metaDataType)
    {
        return _loveBanRatingFieldValueConverter.ConvertFromString(_getTagValue(metaDataType));
    }

    public void SetLoveBanRating(MetaDataType metaDataType, LoveBanRating value)
    {
        _setTagValue(metaDataType, _loveBanRatingFieldValueConverter.ConvertToString(value));
    }
}