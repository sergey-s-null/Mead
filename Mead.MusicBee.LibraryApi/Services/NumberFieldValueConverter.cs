using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Services;

public sealed class NumberFieldValueConverter : IFieldValueConverter<long>
{
    public string ConvertToString(long value)
    {
        throw new NotImplementedException();
    }

    public long ConvertFromString(string value)
    {
        throw new NotImplementedException();
    }
}