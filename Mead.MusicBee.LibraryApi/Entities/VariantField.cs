using Mead.MusicBee.LibraryApi.Entities.Abstract;
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
        get => _fieldValuesConverter.ConvertStringToBool(_getTagValue());
        set => _setTagValue(_fieldValuesConverter.ConvertBoolToString(value));
    }

    public long NumberValue
    {
        get => _fieldValuesConverter.ConvertStringToNumber(_getTagValue());
        set => _setTagValue(_fieldValuesConverter.ConvertNumberToString(value));
    }

    public DateTime DateValue
    {
        get => _fieldValuesConverter.ConvertStringToDate(_getTagValue());
        set => _setTagValue(_fieldValuesConverter.ConvertDateToString(value));
    }

    public IReadOnlyList<string> EnumValue
    {
        get => _fieldValuesConverter.ConvertStringToEnum(_getTagValue());
        set => _setTagValue(_fieldValuesConverter.ConvertEnumToString(value));
    }

    public Rating RatingValue
    {
        get => _fieldValuesConverter.ConvertStringToRating(_getTagValue());
        set => _setTagValue(_fieldValuesConverter.ConvertRatingToString(value));
    }

    private readonly Func<string> _getTagValue;
    private readonly Action<string> _setTagValue;
    private readonly IFieldValuesConverter _fieldValuesConverter;

    public VariantField(
        Func<string> getTagValue,
        Action<string> setTagValue,
        IFieldValuesConverter fieldValuesConverter)
    {
        _getTagValue = getTagValue;
        _setTagValue = setTagValue;
        _fieldValuesConverter = fieldValuesConverter;
    }
}