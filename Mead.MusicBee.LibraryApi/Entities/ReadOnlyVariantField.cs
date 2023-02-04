using Mead.MusicBee.LibraryApi.Entities.Abstract;
using Mead.MusicBee.LibraryApi.Enums;
using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Entities;

public sealed class ReadOnlyVariantField : IReadOnlyVariantField
{
    public string StringValue => _getTagValue();

    public bool BoolValue =>
        _fieldValuesConverter.ConvertStringToBool(_getTagValue());

    public long NumberValue =>
        _fieldValuesConverter.ConvertStringToNumber(_getTagValue());

    public DateTime DateValue =>
        _fieldValuesConverter.ConvertStringToDate(_getTagValue());

    public IReadOnlyList<string> EnumValue =>
        _fieldValuesConverter.ConvertStringToEnum(_getTagValue());

    public Rating RatingValue =>
        _fieldValuesConverter.ConvertStringToRating(_getTagValue());

    private readonly Func<string> _getTagValue;

    private readonly IFieldValuesConverter _fieldValuesConverter;

    public ReadOnlyVariantField(
        Func<string> getTagValue,
        IFieldValuesConverter fieldValuesConverter)
    {
        _getTagValue = getTagValue;
        _fieldValuesConverter = fieldValuesConverter;
    }
}