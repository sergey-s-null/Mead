using Mead.MusicBee.LibraryApi.Exceptions;
using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Services;

public sealed class NumberFieldValueConverter : IFieldValueConverter<long>
{
    public string ConvertToString(long value)
    {
        return value.ToString();
    }

    public long ConvertFromString(string value)
    {
        if (!long.TryParse(value, out var longValue))
        {
            throw new FieldConversionException($"Could not convert value \"{value}\" to long.");
        }

        return longValue;
    }
}