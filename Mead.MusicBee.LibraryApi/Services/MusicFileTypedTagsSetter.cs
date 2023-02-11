using Mead.MusicBee.Enums;
using Mead.MusicBee.LibraryApi.Enums;
using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Services;

public sealed class MusicFileTypedTagsSetter : IMusicFileTypedTagsSetter
{
    private readonly Action<MetaDataType, string> _setTagValue;

    private readonly IFieldValueConverter<bool> _boolFieldValueConverter;
    private readonly IFieldValueConverter<long> _numberFieldValueConverter;
    private readonly IFieldValueConverter<DateTime> _dateFieldValueConverter;
    private readonly IFieldValueConverter<IReadOnlyList<string>> _enumFieldValueConverter;
    private readonly IFieldValueConverter<IReadOnlyList<string>> _encodedEnumFieldValueConverter;
    private readonly IFieldValueConverter<Rating> _ratingFieldValueConverter;
    private readonly IFieldValueConverter<LoveBanRating> _loveBanRatingFieldValueConverter;

    public MusicFileTypedTagsSetter(
        Action<MetaDataType, string> setTagValue,
        IFieldValueConverter<bool> boolFieldValueConverter,
        IFieldValueConverter<long> numberFieldValueConverter,
        IFieldValueConverter<DateTime> dateFieldValueConverter,
        IFieldValueConverter<IReadOnlyList<string>> enumFieldValueConverter,
        IFieldValueConverter<IReadOnlyList<string>> encodedEnumFieldValueConverter,
        IFieldValueConverter<Rating> ratingFieldValueConverter,
        IFieldValueConverter<LoveBanRating> loveBanRatingFieldValueConverter)
    {
        _setTagValue = setTagValue;
        _boolFieldValueConverter = boolFieldValueConverter;
        _numberFieldValueConverter = numberFieldValueConverter;
        _dateFieldValueConverter = dateFieldValueConverter;
        _enumFieldValueConverter = enumFieldValueConverter;
        _encodedEnumFieldValueConverter = encodedEnumFieldValueConverter;
        _ratingFieldValueConverter = ratingFieldValueConverter;
        _loveBanRatingFieldValueConverter = loveBanRatingFieldValueConverter;
    }

    public void SetBool(MetaDataType metaDataType, bool value)
    {
        _setTagValue(metaDataType, _boolFieldValueConverter.ConvertToString(value));
    }

    public void SetNumber(MetaDataType metaDataType, long value)
    {
        _setTagValue(metaDataType, _numberFieldValueConverter.ConvertToString(value));
    }

    public void SetDate(MetaDataType metaDataType, DateTime value)
    {
        _setTagValue(metaDataType, _dateFieldValueConverter.ConvertToString(value));
    }

    public void SetEnum(MetaDataType metaDataType, IReadOnlyList<string> value)
    {
        _setTagValue(metaDataType, _enumFieldValueConverter.ConvertToString(value));
    }

    public void SetEncodedEnum(MetaDataType metaDataType, IReadOnlyList<string> value)
    {
        _setTagValue(metaDataType, _encodedEnumFieldValueConverter.ConvertToString(value));
    }

    public void SetRating(MetaDataType metaDataType, Rating value)
    {
        _setTagValue(metaDataType, _ratingFieldValueConverter.ConvertToString(value));
    }

    public void SetLoveBanRating(MetaDataType metaDataType, LoveBanRating value)
    {
        _setTagValue(metaDataType, _loveBanRatingFieldValueConverter.ConvertToString(value));
    }
}