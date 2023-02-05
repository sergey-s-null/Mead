using Mead.MusicBee.LibraryApi.Entities.Abstract;
using Mead.MusicBee.LibraryApi.Enums;
using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Entities;

public sealed class ReadOnlyVariantField : IReadOnlyVariantField
{
    public string StringValue => _getTagValue();

    public bool BoolValue =>
        _boolFieldValueConverter.ConvertFromString(_getTagValue());

    public long NumberValue =>
        _numberFieldValueConverter.ConvertFromString(_getTagValue());

    public DateTime DateValue =>
        _dateFieldValueConverter.ConvertFromString(_getTagValue());

    public IReadOnlyList<string> EnumValue =>
        _enumFieldValueConverter.ConvertFromString(_getTagValue());

    public Rating RatingValue =>
        _ratingFieldValueConverter.ConvertFromString(_getTagValue());

    private readonly Func<string> _getTagValue;

    private readonly IFieldValueConverter<bool> _boolFieldValueConverter;
    private readonly IFieldValueConverter<long> _numberFieldValueConverter;
    private readonly IFieldValueConverter<DateTime> _dateFieldValueConverter;
    private readonly IFieldValueConverter<IReadOnlyList<string>> _enumFieldValueConverter;
    private readonly IFieldValueConverter<Rating> _ratingFieldValueConverter;

    public ReadOnlyVariantField(
        Func<string> getTagValue,
        IFieldValueConverter<bool> boolFieldValueConverter,
        IFieldValueConverter<long> numberFieldValueConverter,
        IFieldValueConverter<DateTime> dateFieldValueConverter,
        IFieldValueConverter<IReadOnlyList<string>> enumFieldValueConverter,
        IFieldValueConverter<Rating> ratingFieldValueConverter)
    {
        _getTagValue = getTagValue;
        _boolFieldValueConverter = boolFieldValueConverter;
        _numberFieldValueConverter = numberFieldValueConverter;
        _dateFieldValueConverter = dateFieldValueConverter;
        _enumFieldValueConverter = enumFieldValueConverter;
        _ratingFieldValueConverter = ratingFieldValueConverter;
    }
}