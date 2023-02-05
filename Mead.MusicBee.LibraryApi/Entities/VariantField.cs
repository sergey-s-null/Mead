using Mead.MusicBee.LibraryApi.Entities.Abstract;
using Mead.MusicBee.LibraryApi.Enums;
using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Entities;

public sealed class VariantField : IVariantField
{
    public string StringValue
    {
        get => _getTagValue();
        set => _setTagValue(value);
    }

    public bool BoolValue
    {
        get => _boolFieldValueConverter.ConvertFromString(_getTagValue());
        set => _setTagValue(_boolFieldValueConverter.ConvertToString(value));
    }

    public long NumberValue
    {
        get => _numberFieldValueConverter.ConvertFromString(_getTagValue());
        set => _setTagValue(_numberFieldValueConverter.ConvertToString(value));
    }

    public DateTime DateValue
    {
        get => _dateFieldValueConverter.ConvertFromString(_getTagValue());
        set => _setTagValue(_dateFieldValueConverter.ConvertToString(value));
    }

    public IReadOnlyList<string> EnumValue
    {
        get => _enumFieldValueConverter.ConvertFromString(_getTagValue());
        set => _setTagValue(_enumFieldValueConverter.ConvertToString(value));
    }

    public Rating RatingValue
    {
        get => _ratingFieldValueConverter.ConvertFromString(_getTagValue());
        set => _setTagValue(_ratingFieldValueConverter.ConvertToString(value));
    }

    private readonly Func<string> _getTagValue;
    private readonly Action<string> _setTagValue;

    private readonly IFieldValueConverter<bool> _boolFieldValueConverter;
    private readonly IFieldValueConverter<long> _numberFieldValueConverter;
    private readonly IFieldValueConverter<DateTime> _dateFieldValueConverter;
    private readonly IFieldValueConverter<IReadOnlyList<string>> _enumFieldValueConverter;
    private readonly IFieldValueConverter<Rating> _ratingFieldValueConverter;

    public VariantField(
        Func<string> getTagValue,
        Action<string> setTagValue,
        IFieldValueConverter<bool> boolFieldValueConverter,
        IFieldValueConverter<long> numberFieldValueConverter,
        IFieldValueConverter<DateTime> dateFieldValueConverter,
        IFieldValueConverter<IReadOnlyList<string>> enumFieldValueConverter,
        IFieldValueConverter<Rating> ratingFieldValueConverter)
    {
        _getTagValue = getTagValue;
        _setTagValue = setTagValue;
        _boolFieldValueConverter = boolFieldValueConverter;
        _numberFieldValueConverter = numberFieldValueConverter;
        _dateFieldValueConverter = dateFieldValueConverter;
        _enumFieldValueConverter = enumFieldValueConverter;
        _ratingFieldValueConverter = ratingFieldValueConverter;
    }
}